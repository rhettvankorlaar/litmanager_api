using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace litmanager_api.Services
{
    public interface IService<TPost,TGet, TId>
    {
        public Task<bool> AddAsync(TPost objectToCreate);
        public Task<TGet> GetAsync(TId idToGet);
        public Task<List<TGet>> GetAllAsync();
        public Task<bool> DeleteAsync(TId idToGet);
        public Task<bool> UpdateAsync(TGet objectToUpdate);
    }
}
