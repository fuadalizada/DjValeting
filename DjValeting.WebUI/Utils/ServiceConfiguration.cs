using DjValeting.DAL.DbContext;
using DjValeting.DAL.Settings;
using Microsoft.EntityFrameworkCore;

namespace DjValeting.WebUI.Utils
{
    public class ServiceConfiguration : IInstaller
    {
        public void InstallService(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(option => {
                option.UseSqlServer(AppSettings.ConnectionString);
            });

            // Add services to the container.
            services.AddControllersWithViews();
            DependencyInjectionRepositories(services);
            DependencyInjectionServices(services);
        }

        private void DependencyInjectionRepositories(IServiceCollection services)
        {

        }

        private void DependencyInjectionServices(IServiceCollection services)
        {

        }
    }
}
