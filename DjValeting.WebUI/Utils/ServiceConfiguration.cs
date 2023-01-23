using AutoMapper;
using DjValeting.Business.MapConfig;
using DjValeting.Business.Services.Abstract;
using DjValeting.Business.Services.Concrete;
using DjValeting.DAL.DbContext;
using DjValeting.DAL.Repositories.Abstract;
using DjValeting.DAL.Repositories.Concrete;
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
            DependencyInjectionMappers(services);
        }

        private void DependencyInjectionRepositories(IServiceCollection services)
        {
            services.AddScoped<IAuthenticateRepository, AuthenticateRepository>();
            services.AddScoped<IBookingFormRepository, BookingFormRepository>();
            services.AddScoped<IFlexibilityRepository, FlexibilityRepository>();
            services.AddScoped<IVehicleSizeRepository, VehicleSizeRepository>();
        }

        private void DependencyInjectionServices(IServiceCollection services)
        {
            services.AddScoped<IAuthenticateService,AuthenticateService>();
            services.AddScoped<IBookingFormService,BookingFormService>();
            services.AddScoped<IFlexibilityService,FlexibilityService>();
            services.AddScoped<IVehicleSizeService,VehicleSizeService>();
        }

        private void DependencyInjectionMappers(IServiceCollection service)
        {
            var mapConfig = new MapperConfiguration(config => { config.AddProfile(new MapperConfig()); });
            IMapper mapper = mapConfig.CreateMapper();
            service.AddSingleton(mapper);
        }
    }
}
