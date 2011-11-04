using System;
using System.Configuration;
using System.Web.Configuration;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (string.IsNullOrEmpty(ConfigurationManager.AppSettings["WindowsLoginCredentials"]))
            {
                VirtualDirectoryMapping vdm = new VirtualDirectoryMapping(@"C:\LDS\Phoenix\PhoenixWeb", true);
                WebConfigurationFileMap wcfm = new WebConfigurationFileMap();
                wcfm.VirtualDirectories.Add("/", vdm);

                // Get the Web application configuration object.
                Configuration config = WebConfigurationManager.OpenMappedWebConfiguration(wcfm, "/");

                string s = config.AppSettings.Settings["WindowsLoginCredentials"].Value;
            }
//More Stuff

            Console.Read();
        }

    }
}
