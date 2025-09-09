using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NCQ.Test.Gui.Windows.Components;
using System;

namespace NCQ.Test.Gui
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            //System.Windows.Forms.Application.Run(ServiceProvider.GetRequiredService<Main>());
            System.Windows.Forms.Application.Run(new AlterModal());
        }

        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddGuiDependencies(context.Configuration);
                });
        }
    }
}
