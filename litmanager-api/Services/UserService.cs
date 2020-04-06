using litmanager_api.Contracts.V1.Requests.User;
using litmanager_api.Domain;
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
            if (_context.Users.Any(_ => _.Id == objectToCreate.Id || _.Email == objectToCreate.Email))
            {
                return false;
            }
            //Adds user to the database
            _context.Users.Add(objectToCreate);

            var created = await _context.SaveChangesAsync();
            return created > 0;
        }

        public Task<bool> DeleteAsync(string idToGet)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetAsync(string idToGet)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(string idToGet, User objectToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
