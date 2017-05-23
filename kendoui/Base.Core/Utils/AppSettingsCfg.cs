using System;
using System.Configuration;

namespace Base.Core.Utils
{
    public class AppSettingsCfg
    {
        public static bool GetUseMonoSqliteDriverKey()
        {
            bool keyValue = false;

            if (ConfigurationManager.AppSettings.Get("UseMonoSqliteDriver") != null)
                keyValue = bool.Parse(ConfigurationManager.AppSettings.Get("UseMonoSqliteDriver"));
            //else
                //Console.WriteLine(@"No key value in App.Config <add key=""UseMonoSqliteDriver"" value="""" /> defaulting to " + keyValue.ToString());

            return keyValue;
        }

        public static bool GetBuildSchemaKey()
        {
            bool keyValue = true;

            if (ConfigurationManager.AppSettings.Get("BuildSchema") != null)
                keyValue = bool.Parse(ConfigurationManager.AppSettings.Get("BuildSchema"));
            else
                Console.WriteLine(@"No key value in App.Config <add key=""BuildSchema"" value="""" /> defaulting to " + keyValue.ToString());

            return keyValue;
        }

        public static string GetDbFileKey()
        {
            string keyValue = "APPDB.db";

            if (ConfigurationManager.AppSettings.Get("DbFile") != null)
                keyValue = ConfigurationManager.AppSettings.Get("DbFile");
            //else
                //Console.WriteLine(@"No key value in App.Config <add key=""DbFileKey"" value="""" /> defaulting to " + keyValue.ToString());

            return keyValue;
        }

        public static bool GetUseHostBaseAddressKey()
        {
            bool keyValue = false;

            if (ConfigurationManager.AppSettings.Get("UseHostBaseAddress") != null)
                keyValue = bool.Parse(ConfigurationManager.AppSettings.Get("UseHostBaseAddress"));
            else
                Console.WriteLine(@"No key value in App.Config <add key=""UseHostBaseAddress"" value="""" /> defaulting to " + keyValue.ToString());

            return keyValue;
        }

        public static string GetHostBaseAddressKey()
        {
            string keyValue = "http://localhost:80";

            if (ConfigurationManager.AppSettings.Get("HostBaseAddress") != null)
                keyValue = ConfigurationManager.AppSettings.Get("HostBaseAddress");
            else
                Console.WriteLine(@"No key value in App.Config <add key=""HostBaseAddress"" value="""" /> defaulting to " + keyValue.ToString());

            return keyValue;
        }

        public static bool GetUseHostBasePortKey()
        {
            bool keyValue = false;

            if (ConfigurationManager.AppSettings.Get("UseHostBasePort") != null)
                keyValue = bool.Parse(ConfigurationManager.AppSettings.Get("UseHostBasePort"));
            else
                Console.WriteLine(@"No key value in App.Config <add key=""UseHostBasePort"" value="""" /> defaulting to " + keyValue.ToString());

            return keyValue;
        }

        public static string GetHostBasePortKey()
        {
            string keyValue = "80";

            if (ConfigurationManager.AppSettings.Get("HostBasePort") != null)
                keyValue = ConfigurationManager.AppSettings.Get("HostBasePort");
            else
                Console.WriteLine(@"No key value in App.Config <add key=""HostBasePort"" value="""" /> defaulting to " + keyValue.ToString());

            return keyValue;
        }

    }
    
}

