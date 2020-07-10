using System;
using System.Threading.Tasks;
using Homely.AspNetCore.Hosting.CoreApp;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace SampleBackgroundTask
{
    public class Program
    {
        public static Task Main(string[] args)
        {
            var options = new MainOptions
            {
                CommandLineArguments = args,
                FirstLoggingInformationMessage = "~~ Sample Background Task ~~",
                LogAssemblyInformation = true,
                LastLoggingInformationMessage = "-- Sample Background Task has ended/terminated --",
                CustomConfigureServices = new Action<HostBuilderContext, IServiceCollection>((hostContext, services) =>
                {
                    services.AddHostedService<Worker>();
                }),
                CustomPreRunAction = new Action<IHost>(host =>
                {
                    using (var scope = host.Services.CreateScope())
                    {
                        var services = scope.ServiceProvider;
                        var logger = services.GetRequiredService<ILogger<Program>>();
                        logger.LogInformation("Inside the CustomPreRunAction method. Woot!");
                    }
                })
            };


            return Homely.AspNetCore.Hosting.CoreApp.Program.Main<Program>(options);
        }
    }
}
