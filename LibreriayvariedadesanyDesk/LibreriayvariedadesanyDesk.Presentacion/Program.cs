using LibreriayvariedadesanyDeskPresentacion.Formularios;
using LibreriayvariedadesanyDeskRepository;
using LibreriayvariedadesanyDeskServices;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace LibreriayvariedadesanyDesk.Presentacion
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var host = CreateHostBuilder().Build();
            var formService = host.Services.GetRequiredService<frmUsuario>();
            Application.Run(formService);
        }

        static IHostBuilder CreateHostBuilder() =>
           Host.CreateDefaultBuilder()
           .ConfigureAppConfiguration((context, config) =>
           {
               var basePath = AppContext.BaseDirectory; // Obtiene la ruta del ejecutable
               config.SetBasePath(basePath); // Establece la ruta base
               config.AddJsonFile(Path.Combine(basePath, "appsettings.json"), optional: false, reloadOnChange: true);
           })
           .ConfigureServices((context, services) =>
           {
               services.RegisterRepositoryDependendies();
               services.RegisterServicesDependendies();
               services.AddTransient<frmUsuario>();

           });

    }
}