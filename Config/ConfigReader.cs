using System.IO;
using Microsoft.Extensions.Configuration;

namespace AppiumFramework.Config
{
    public class ConfigReader
    {
        public static void InitializeSettings()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            IConfigurationRoot configurationRoot = builder.Build();

            Settings.PlatformName = configurationRoot.GetSection("testSettings").Get<TestSettings>().PlatformName;
            Settings.DeviceName = configurationRoot.GetSection("testSettings").Get<TestSettings>().DeviceName;
            Settings.AppPath = configurationRoot.GetSection("testSettings").Get<TestSettings>().AppPath;
            Settings.AppPackage = configurationRoot.GetSection("testSettings").Get<TestSettings>().AppPackage;
            Settings.AppActivity = configurationRoot.GetSection("testSettings").Get<TestSettings>().AppActivity;
        }
    }
}
