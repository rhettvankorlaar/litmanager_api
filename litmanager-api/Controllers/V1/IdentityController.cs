using litmanager_api.Contracts.V1;
using litmanager_api.Contracts.V1.Requests.Identity;
using litmanager_api.Contracts.V1.Responses.Identity;
using litmanager_api.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace litmanager_api.Controllers.V1
{
    public class IdentityController : Controller
    {
        private readonly IdentityService _identityService;
        private readonly UserService _userService;
        public IdentityController(IdentityService identityService, UserService userService)
        {
            _identityService = identityService;
            _userService = userService;

        }

        [HttpPost(ApiRoutes.Identity.Login)]
        public async Task<IActionResult> Login([FromBody]TokenRequest request)
        {
            var user = await _userService.GetByEmailAsync(request.Email);

            if (user == null)
            {
                return BadRequest(new AuthResponse 
                { 
                    IsSuccess = false,
                    Errors = new[] {"Verkeerde email/wachtwoord combinatie."}
                });
            }

            var loginResult = await _identityService.LoginAsync(user, request.Password);

            if (!loginResult.IsSuccess)
            {
                return BadRequest(new AuthResponse
                {
                    IsSuccess = false,
                    Errors = loginResult.Errors
                });
            }
            return Ok(loginResult);
        }

        [HttpPost(ApiRoutes.Identity.Refresh)]
        public async Task<IActionResult> Refresh([FromBody]RefreshRequest request)
        {
            var refreshResult = await _identityService.RefreshTokenAsync(request.Token, request.RefreshToken);

            if (!refreshResult.IsSuccess)
            {
                return BadRequest(new AuthResponse
                {
                    Errors = refreshResult.Errors
                });
            }

            return Ok(refreshResult);
        }
    }
}
