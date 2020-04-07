using AutoMapper;
using litmanager_api.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace litmanager_api.Installers
{
    public class ServiceInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration Configuration)
        {
            //CORS
            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));

            services.AddAutoMapper(typeof(Startup));

            services.AddScoped<RegistrationService>();
            services.AddScoped<UserService>();
            services.AddScoped<UserTypeService>();
            services.AddScoped<IdentityService>();
            services.AddScoped<SecurityService>();
        }
    }
}
