using System.Threading.Tasks;
using Homely.AspNetCore.Hosting.CoreApp;

namespace WebApplication1
{
    public class Program
    {
        public static Task Main(string[] args)
        {
            var options = new MainOptions
            {
                CommandLineArguments = args,
                FirstLoggingInformationMessage = "~~ Test Web Api ~~",
                LogAssemblyInformation = true,
                LastLoggingInformationMessage = "-- Test Web Api has ended/terminated --"
            };

            return Homely.AspNetCore.Hosting.CoreApp.Program.Main<Startup>(options);
        }
    }
}
