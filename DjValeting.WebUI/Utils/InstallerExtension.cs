﻿namespace DjValeting.WebUI.Utils
{
    public static class InstallerExtension
    {
        public static void InstallServicesInAssemblies(this IServiceCollection services, IConfiguration configuration)
        {
            var installers = typeof(Program).Assembly.ExportedTypes.Where(x => typeof(IInstaller).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                .Select(Activator.CreateInstance).Cast<IInstaller>().ToList();
            installers.ForEach(installer => installer.InstallService(services, configuration));
        }
    }
}
