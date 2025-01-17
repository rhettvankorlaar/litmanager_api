﻿using AutoMapper;
using litmanager_api.Contracts.V1.Requests.Registration;
using litmanager_api.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace litmanager_api.Services
{
    public class RegistrationService : IService<CreateRequest,Registration, string>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public RegistrationService(DataContext context, IMapper mapper)
        {             
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> AddAsync(CreateRequest objectToCreate)
        {
            //Check if the email or id already exists in the database.
            if(await _context.Registrations.AnyAsync(_=>_.Id == objectToCreate.Id || _.Email == objectToCreate.Email))
            {
                return false;
            }
            //Map object to registration
            var registration = _mapper.Map<Registration>(objectToCreate);

            //Normalize email
            registration.Email = registration.Email.ToUpper();
            //Add to the database
            _context.Registrations.Add(registration);
            
            //Save and check if anything updated
            var created = await _context.SaveChangesAsync();
            return created > 0;
        }

        public async Task<List<Registration>> GetAllAsync()
        {
            //Return a list of all registrations
            return await _context.Registrations.Include(_ => _.UserType).ToListAsync();
        }

        public async Task<Registration> GetAsync(string idToGet)
        {
            //Return the registration or null
            return await _context.Registrations.Include(_=>_.UserType).SingleOrDefaultAsync(_ => _.Id == idToGet);
        }
        public async Task<bool> UpdateAsync(Registration objectToUpdate)
        {
            //Update and save to database
            _context.Registrations.Update(objectToUpdate);
            var updated = await _context.SaveChangesAsync();
            return updated > 0;
        }

        public async Task<bool> DeleteAsync(string idToGet)
        {
            //Check if the Registration exists
            var registrationToDelete = await GetAsync(idToGet);
            if (registrationToDelete == null)
            {
                return false;
            }
            //Remove and save to database
            _context.Registrations.Remove(registrationToDelete);
            var removed = await _context.SaveChangesAsync();

            //return true if there are more than 0 changes
            return removed > 0;
        }
    }
}
