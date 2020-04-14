using litmanager_api.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace litmanager_api.Services
{
    public class UserService : IService<User, User, string>
    {
        private readonly DataContext _context;
        private readonly SecurityService _security;
        public UserService(DataContext context, SecurityService security)
        {
            _context = context;
            _security = security;
        }

        public async Task<bool> AddAsync(User objectToCreate)
        {
            //Check if the email or id already exists in the database.
            if(await UserExists(objectToCreate.Id, objectToCreate.Email))
            {
                return false;
            }
            //Adds user to the database
            _context.Users.Add(objectToCreate);

            var created = await _context.SaveChangesAsync();
            return created > 0;
        }

        public async Task<User> GetAsync(string idToGet)
        {
            //Returns a user or null
            return await _context.Users.Include(_=>_.UserType).SingleOrDefaultAsync(_ => _.Id == idToGet);
        }

        public async Task<List<User>> GetAllAsync()
        {
            //Return a list of all users
            return await _context.Users.Include(_ => _.UserType).ToListAsync();
        }
        public async Task<bool> UpdateAsync(User objectToUpdate)
        {
            _context.Update(objectToUpdate);

            var updated = await _context.SaveChangesAsync();
            return updated > 0;
        }
        public async Task<bool> DeleteAsync(string idToGet)
        {
            //Check if the User exists
            var userToDelete = await GetAsync(idToGet);
            if (userToDelete == null)
            {
                return false;
            }
            //Remove and save to database
            _context.Users.Remove(userToDelete);
            var removed = await _context.SaveChangesAsync();

            //return true if there are more than 0 changes
            return removed > 0;
        }

        public async Task<bool> ChangePasswordAsync(string userId, string password)
        {
            var userToUpdate = await GetAsync(userId);
            if (userToUpdate == null)
            {
                return false;
            }
            //Hash the new password and add to user
            userToUpdate.PasswordHash = _security.HashPassword(password);

            //Update and save to database
            _context.Users.Update(userToUpdate);
            var updated = await _context.SaveChangesAsync();

            //return true if there are more than 0 changes
            return updated > 0;
        }

        public async Task<User> GetByEmailAsync(string email)
        {
            //Returns a user or null
            return await _context.Users.Include(_ => _.UserType).SingleOrDefaultAsync(_ => _.Email == email.ToUpper());
        }

        public async Task<bool> UserExists(string id, string email)
        {
            if (await _context.Users.AnyAsync(_ => _.Id == id || _.Email == email))
            {
                return true;
            }
            return false;
        }
    }
}
