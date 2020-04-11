using litmanager_api.Domain;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace litmanager_api.Services
{
    public class UserTypeService : IService<UserType, UserType, Guid>
    {
        private readonly DataContext _context;
        public UserTypeService(DataContext context)
        {
            _context = context;
        }

        public async Task<bool> AddAsync(UserType objectToCreate)
        {
            //Check if usertype already exists in the database
            if (await _context.UserTypes.AnyAsync(_ => _.Type == objectToCreate.Type))
            {
                return false;
            }
            //Adds usertype to the database
            _context.UserTypes.Add(objectToCreate);

            var created = await _context.SaveChangesAsync();
            return created > 0;
        }

        public async Task<List<UserType>> GetAllAsync()
        {
            //Return a list of all usertypes
            return await _context.UserTypes.ToListAsync();
        }

        public async Task<UserType> GetAsync(Guid idToGet)
        {
            //returns usertype or null
            return await _context.UserTypes.SingleOrDefaultAsync(_ => _.Id == idToGet);
        }

        public async Task<bool> UpdateAsync(UserType objectToUpdate)
        {
            //Update and save to database
            _context.UserTypes.Update(objectToUpdate);
            var updated = await _context.SaveChangesAsync();

            //return true if there are more than 0 changes
            return updated > 0;
        }

        public async Task<bool> DeleteAsync(Guid idToGet)
        {
            //Check if the UserType exists
            var userTypeToDelete = await GetAsync(idToGet);
            if (userTypeToDelete == null)
            {
                return false;
            }
            //Remove and save to database
            _context.UserTypes.Remove(userTypeToDelete);
            var removed = await _context.SaveChangesAsync();

            //return true if there are more than 0 changes
            return removed > 0;
        }

        public Task<bool> PatchAsync(Guid idToPatch, JsonPatchDocument patchDocument)
        {
            throw new NotImplementedException();
        }
    }
}
