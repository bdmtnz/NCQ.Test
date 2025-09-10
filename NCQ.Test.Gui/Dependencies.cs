using Mapster;
using MapsterMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NCQ.Test.Gui.Application;
using NCQ.Test.Gui.Infrastructure;
using System.Reflection;

namespace NCQ.Test.Gui
{
    public static class Dependencies
    {
        public static IServiceCollection AddGuiDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<Main>();

            services
                .AddMappings()
                .AddInfrastructureDependencies(configuration)
                .AddApplicationDependencies();

            return services;
        }

        private static IServiceCollection AddMappings(this IServiceCollection services)
        {
            TypeAdapterConfig config = TypeAdapterConfig.GlobalSettings;
            config.Scan(Assembly.GetExecutingAssembly());
            services.AddSingleton(config);
            services.AddScoped<IMapper, ServiceMapper>();
            return services;
        }
    }
}
