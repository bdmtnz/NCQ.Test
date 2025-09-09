using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NCQ.Test.Gui.Domain.Common.Contracts.Persistence;
using NCQ.Test.Gui.Domain.Common.Contracts.Persistence.Repositories;
using NCQ.Test.Gui.Infrastructure.Common;
using NCQ.Test.Gui.Infrastructure.SqLite;
using System.Data.SQLite;

namespace NCQ.Test.Gui.Infrastructure
{
    public static class InfrastructureDependencies
    {
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddPersistenceDependencies(configuration);

            return services;
        }

        private static IServiceCollection AddPersistenceDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            var connection = new SQLiteConnection("Data Source=Assets/Tasks.db;Version=3;");
            services.AddSingleton<SQLiteConnection>(connection);

            services.AddScoped<ICache, MemoryCache>();

            services.AddScoped<ITermRepository, TermRepository>();
            services.AddScoped<ITaskRepository, TaskRepository>();

            return services;
        }
    }
}
