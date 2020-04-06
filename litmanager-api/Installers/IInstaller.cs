using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace litmanager_api.Installers
{
    public interface IInstaller
    {
        void InstallServices(IServiceCollection services, IConfiguration Configuration);
    }
}
