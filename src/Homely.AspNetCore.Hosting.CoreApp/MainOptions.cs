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
        /// Optional text which is last displayed when the application stops.
        /// </summary>
        /// <remarks>This could be useful to help determine when things are finally stopping.</remarks>
        public string LastLoggingInformationMessage { get; set; }

        /// <summary>
        /// The name of the Environment Variable which contains the 'Environment' value (e.g. Development, Production, etc).
        /// </summary>
        /// <remarks>Defaults to <code>ASPNETCORE_ENVIRONMENT</code></remarks>
        public string EnvironmentVariableKey { get; set; } = "ASPNETCORE_ENVIRONMENT";
    }
}
