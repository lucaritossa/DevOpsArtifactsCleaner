using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Ritossa.DevOpsArtifactsCleaner.Services.Contracts;

namespace Ritossa.DevOpsArtifactsCleaner.Services
{
    public static class AppBuilderExtensions
    {
        public static IHostBuilder RegisterServices(this IHostBuilder hostBuilder)
        {
            hostBuilder.ConfigureServices((context, services) =>
            {
                services.AddTransient<IUserSettingsService, UserSettingsService>();
                services.AddTransient<IDevOpsService, DevOpsService>();
            });

            return hostBuilder;
        }
    }
}
