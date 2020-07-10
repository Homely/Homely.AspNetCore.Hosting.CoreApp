using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Homely.AspNetCore.Hosting.CoreApp
{
    public class MainOptions
    {
        /// <summary>
        /// Command line arguments.
        /// </summary>
        public string[] CommandLineArguments { get; set; }

        /// <summary>
        /// Optional text which is first displayed when the application starts.
        /// </summary>
        /// <remarks>This can be useful to help determine if things have started and are working ok.</remarks>
        public string FirstLoggingInformationMessage { get; set; }

        /// <summary>
        /// Write the assembly name, version and date information to the logger?
        /// </summary>
        public bool LogAssemblyInformation { get; set; } = true;

        /// <summary>
        /// Optional text which is last displayed when the application stops.
        /// </summary>
        /// <remarks>This could be useful to help determine when things are finally stopping.</remarks>
        public string LastLoggingInformationMessage { get; set; }

        /// <summary>
        /// The name of the Environment Variable which contains the 'Environment' value (e.g. Development, Production, etc). This could be different based on the host - for example, ASP.NET uses ASPNETCORE_ENVIRONMENT as it's default key/value while a console app or background host might be different.
        /// </summary>
        /// <remarks>Defaults to <code>ASPNETCORE_ENVIRONMENT</code>.</remarks>
        public string EnvironmentVariableKey { get; set; } = "ASPNETCORE_ENVIRONMENT";

        /// <summary>
        /// Custom action to configure your own services instead of using the WebHost defaults.<br/>
        /// An example of this would be for your own Background Tasks which has no Kestrel server, running.
        /// </summary>
        public Action<HostBuilderContext, IServiceCollection> CustomConfigureServices { get; set; }

        /// <summary>
        /// Custom logic to invoke on the Host that was built, but before the host starts.<br/>
        /// An example of this could be some database migrations.
        /// </summary>
        public Action<IHost> CustomPreRunAction { get; set; }
    }
}
