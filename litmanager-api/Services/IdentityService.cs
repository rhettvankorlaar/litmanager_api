using litmanager_api.Contracts.V1.Responses.Identity;
using litmanager_api.Domain;
using litmanager_api.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace litmanager_api.Services
{
    public class IdentityService
    {
        private readonly JwtSettings _jwt;
        private readonly DataContext _context;
        private readonly TokenValidationParameters _tokenValidationParameters;
        private readonly SecurityService _security;
        public IdentityService(JwtSettings jwt, DataContext context, TokenValidationParameters tokenValidationParameters, SecurityService security)
        {
            _jwt = jwt;
            _context = context;
            _tokenValidationParameters = tokenValidationParameters;
            _security = security;
        }

        public async Task<AuthResponse> LoginAsync(User user, string password)
        {

            if (!_security.VerifyPassword(password, user.PasswordHash))
            {
                return new AuthResponse
                {
                    Errors = new[] { "Verkeerde email/wachtwoord combinatie" }
                };
            }

            if (!user.IsEnabled)
            {
                return new AuthResponse
                {
                    Errors = new[] { "Gebruiker is uitgeschakeld" }
                };
            }
            return await GenerateToken(user);
        }

        public async Task<AuthResponse> RefreshTokenAsync(string token, string refreshToken)
        {
            var validatedToken = GetPrincipalFromToken(token);

            if (validatedToken == null)
            {
                return new AuthResponse
                {
                    Errors = new[] { "Invalid token" }
                };
            }
            var expiryDateUnix =
                long.Parse(validatedToken.Claims.Single(_ => _.Type == JwtRegisteredClaimNames.Exp).Value);

            var expiryDateTimeUtc = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                .AddSeconds(expiryDateUnix)
                .Subtract(_jwt.TokenLifetime);

            if (expiryDateTimeUtc > DateTime.UtcNow)
            {
                return new AuthResponse
                {
                    Errors = new[] { "This token hasnt expired yet." }
                };
            }

            var jti = validatedToken.Claims.Single(_ => _.Type == JwtRegisteredClaimNames.Jti).Value;

            var storedRefreshToken = await _context.RefreshTokens.SingleOrDefaultAsync(_ => _.Token == refreshToken);

            if (storedRefreshToken == null)
            {
                return new AuthResponse
                {
                    Errors = new[] { "Dit token bestaat niet" }
                };
            }

            if (DateTime.UtcNow > storedRefreshToken.ExpiryDate)
            {
                return new AuthResponse
                {
                    Errors = new[] { "Dit token is verlopen" }
                };
            }

            if (storedRefreshToken.Invalidated)
            {
                return new AuthResponse
                {
                    Errors = new[] { "This refresh token has been invalidated" }
                };
            }

            if (storedRefreshToken.JwtId != jti)
            {
                return new AuthResponse
                {
                    Errors = new[] { "This refresh token does not match this JWT" }
                };
            }


            _context.Remove(storedRefreshToken);
            await _context.SaveChangesAsync();

            var userId = validatedToken.Claims.Single(_ => _.Type == "id").Value;

            var user = await _context.Users.SingleOrDefaultAsync(_ => _.Id == userId);

            return await GenerateToken(user);

        }

        private ClaimsPrincipal GetPrincipalFromToken(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            try
            {
                var tokenValidationParameters = _tokenValidationParameters.Clone();
                tokenValidationParameters.ValidateLifetime = false;
                var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out var validatedToken);
                if (!IsJwtWithValidSecurityAlg(validatedToken))
                {
                    return null;
                }

                return principal;
            }
            catch
            {
                return null;
            }
        }

        private bool IsJwtWithValidSecurityAlg(SecurityToken validatedToken)
        {
            return (validatedToken is JwtSecurityToken jwtSecurityToken) &&
                jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256,
                StringComparison.InvariantCultureIgnoreCase);
        }

        private async Task<AuthResponse> GenerateToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_jwt.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Email, user.Email),
                    new Claim("id", user.Id.ToString()),
                    new Claim("usertype", user.UserType.Type ),
                    new Claim("isadmin", user.IsAdmin.ToString())
                }),
                Expires = DateTime.UtcNow.Add(_jwt.TokenLifetime),
                SigningCredentials =
                    new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            var refreshToken = new RefreshToken
            {
                JwtId = token.Id,
                UserId = user.Id,
                CreationDate = DateTime.UtcNow,
                ExpiryDate = DateTime.UtcNow.AddMonths(6)
            };

            _context.RefreshTokens.Add(refreshToken);
            await _context.SaveChangesAsync();

            return new AuthResponse
            {
                IsSuccess = true,
                Token = tokenHandler.WriteToken(token),
                RefreshToken = refreshToken.Token
            };
        }



    }
}
