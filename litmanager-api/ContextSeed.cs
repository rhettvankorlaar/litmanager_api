using litmanager_api;
using litmanager_api.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API
{
    public class ContextSeed
    {
        private static Boolean? useInMemory = null;

        public static void Init(Boolean _useInMemory = false)
        {
            useInMemory = _useInMemory;
        }
        public static void SeedAsync(IServiceProvider services)
        {
            var _context = services.GetRequiredService<DataContext>();

            if (useInMemory == null)
            {
                throw new ApplicationException("Please initialize the ContextSeed using the Init method.");
            }

            if (!useInMemory.Value)
            {
                _context.Database.Migrate();
            } 
        }
    }
}
