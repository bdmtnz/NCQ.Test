using Microsoft.Extensions.DependencyInjection;

namespace NCQ.Test.Gui
{
    public static class Dependencies
    {
        public static IServiceCollection AddGuiDependencies(this IServiceCollection services)
        {
            services.AddTransient<Main>();

            return services;
        }
    }
}
