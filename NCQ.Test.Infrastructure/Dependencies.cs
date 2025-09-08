using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NCQ.Test.Infrastructure.Common;
using NCQ.Test.Infrastructure.Common.Contexts;

namespace NCQ.Test.Infrastructure
{
    public static class Dependencies
    {
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddPersistenceDependencies(configuration);

            return services;
        }

        private static IServiceCollection AddPersistenceDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SqLiteDbContext>(opts =>
            {
                opts.UseSqlite(connectionString: "Data Source=Session.db", opt =>
                {
                    opt.MigrationsAssembly("NCQ.Test.Infrastructure");
                });
                opts.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            }, ServiceLifetime.Transient);

            //services.AddTransient<IUnitOfWork, UnitOfWork>();
            //services.AddTransient<AuthService>();
            //services.AddTransient<PreferenceService>();
            //services.AddTransient<IFileRepository, FileRepository>();

            return services;
        }
    }
}
