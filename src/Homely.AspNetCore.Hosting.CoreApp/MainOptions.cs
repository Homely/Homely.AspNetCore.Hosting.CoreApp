namespace Homely.AspNetCore.Hosting.CoreApp
{
    public class MainOptions
    {
        /// <summary>
        /// Command line arguments.
        /// </summary>
        public string[] CommandLineArguments { get; set; }

        /// <summary>
        /// Optional text which is first displayed when the application starts. This can be useful to help determine if things have started and are working ok.
        /// </summary>
        public string FirstLoggingInformationMessage { get; set; }

        /// <summary>
        /// The name of the Environment Variable which contains the 'Environment' value (e.g. Development, Production, etc).
        /// </summary>
        /// <remarks>Defaults to <code>ASPNETCORE_ENVIRONMENT</code></remarks>
        public string EnvironmentVariableKey { get; set; } = "ASPNETCORE_ENVIRONMENT";

        /// <summary>
        /// Is the main application.json file, optional?
        /// </summary>
        /// <remarks>Defaults to <code>true</code>.</remarks>
        public bool ApplicationJsonFileOptional { get; set; } = true;
    }
}
