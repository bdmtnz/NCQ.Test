using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NCQ.Test.Infrastructure;

namespace NCQ.Test.Gui
{
    public static class Dependencies
    {
        public static IServiceCollection AddGuiDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<Main>();

            services.AddInfrastructureDependencies(configuration);

            return services;
        }
    }
}
