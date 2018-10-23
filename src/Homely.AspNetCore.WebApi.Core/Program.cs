using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Serilog;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Homely.AspNetCore.WebApi.Template
{
    public static class Program
    {
        public static IConfiguration Configuration { get; } = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json", optional: true)
            .AddEnvironmentVariables()
            .Build();

        public static Task Main<T>(string[] args) where T : class
        {
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(Configuration)
                .Enrich.FromLogContext()
                .CreateLogger();
            
            try
            {
                return CreateWebHostBuilder<T>(args).Build()
                                                    .RunAsync();
            }
            catch (Exception exception)
            {
                // TODO: Add metrics (like Application Insights?) to log telemetry failures.
                Log.Logger.Fatal(exception, "Host terminated unexpectantly. Sadness :~(");
            }
            finally
            {
                // Ensure to flush and stop internal timers/threads before application-exit (Avoid segmentation fault on Linux)
                Log.CloseAndFlush();
            }

            return Task.CompletedTask;
        }

        public static IWebHostBuilder CreateWebHostBuilder<T>(string[] args) where T : class =>
            WebHost.CreateDefaultBuilder(args)
                   .UseStartup<T>()
                   .UseConfiguration(Configuration)
                   .UseSerilog();
    }
}
