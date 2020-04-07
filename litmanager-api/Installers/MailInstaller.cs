using litmanager_api.Mail;
using litmanager_api.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace litmanager_api.Installers
{
    public class MailInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration Configuration)
        {
            var emailConfig = Configuration.GetSection("EmailConfiguration").Get<EmailConfiguration>();
            services.AddSingleton(emailConfig);

            services.AddScoped<IMailSender, MailSender>();
        }
    }
}
