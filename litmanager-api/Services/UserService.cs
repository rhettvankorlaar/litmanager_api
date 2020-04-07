using litmanager_api.Contracts.V1.Requests.User;
using litmanager_api.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace litmanager_api.Services
{
    public class UserService : IService<User, User, string>
    {
        private readonly DataContext _context;
        public UserService(DataContext context)
        {
            _context = context;
        }

        public async Task<bool> AddAsync(User objectToCreate)
        {
            //Check if the email or id already exists in the database.
            if (await _context.Users.AnyAsync(_ => _.Id == objectToCreate.Id || _.Email == objectToCreate.Email))
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
            return await _context.Users.SingleOrDefaultAsync(_ => _.Id == idToGet);
        }

        public async Task<List<User>> GetAllAsync()
        {
            //Return a list of all users
            return await _context.Users.ToListAsync();
        }
        public async Task<bool> UpdateAsync(string idToGet, User objectToUpdate)
        {
            //Check if the User exists
            var userToUpdate = await GetAsync(idToGet);
            if (userToUpdate == null)
            {
                return false;
            }

            //Pass the update object the id required to update
            objectToUpdate.Id = idToGet;

            //Update and save to database
            _context.Users.Update(objectToUpdate);
            var updated = await _context.SaveChangesAsync();

            //return true if there are more than 0 changes
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

    }
}
