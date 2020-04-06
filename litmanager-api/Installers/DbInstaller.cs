using API;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace litmanager_api.Installers
{
    public class DbInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<DataContext>(options =>
            {
                ContextSeed.Init();
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });
        }
    }
}
