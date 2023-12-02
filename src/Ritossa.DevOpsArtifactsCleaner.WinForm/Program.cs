using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Ritossa.DevOpsArtifactsCleaner.Services;
using Ritossa.DevOpsArtifactsCleaner.WinForm.Forms;

namespace Ritossa.DevOpsArtifactsCleaner.WinForm
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }
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
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<MainForm>());
        }

        static IHostBuilder CreateHostBuilder()
        {
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddTransient<MainForm>();
                    services.AddTransient<AboutBox>();
                    services.AddTransient<OptionsForm>();
                });

            host.RegisterServices();

            return host;
        }
    }
}