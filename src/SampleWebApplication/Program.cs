using System;
using System.Threading.Tasks;
using Homely.AspNetCore.Hosting.CoreApp;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace SampleWebApplication
{
    public class Program
    {
        public static Task Main(string[] args)
        {
            var options = new MainOptions
            {
                CommandLineArguments = args,
                FirstLoggingInformationMessage = "~~ Sample Web Application ~~",
                LogAssemblyInformation = true,
                LastLoggingInformationMessage = "-- Sample Web Application has ended/terminated --",
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

            return Homely.AspNetCore.Hosting.CoreApp.Program.Main<Startup>(options);
        }
    }
}
