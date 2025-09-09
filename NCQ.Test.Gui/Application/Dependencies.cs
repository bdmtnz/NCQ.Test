using Microsoft.Extensions.DependencyInjection;
using NCQ.Test.Gui.Application.Services;
using NCQ.Test.Gui.Domain.Common.Contracts.Service;

namespace NCQ.Test.Gui.Application
{
    public static class ApplicationDependencies
    {
        public static IServiceCollection AddApplicationDependencies(this IServiceCollection services)
        {
            services.AddTransient<ITermService, TermService>();
            services.AddTransient<ITaskService, TaskService>();

            return services;
        }
    }
}
