using System.IO;
using Microsoft.Extensions.Configuration;

namespace AppiumFramework.Config
{
    public class ConfigReader
    {
        public static void InitializeSettings(string jsonSection)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            IConfigurationRoot configurationRoot = builder.Build();

            Settings.PlatformName = configurationRoot.GetSection(jsonSection).Get<TestSettings>().PlatformName;
            Settings.DeviceName = configurationRoot.GetSection(jsonSection).Get<TestSettings>().DeviceName;
            Settings.AppPath = configurationRoot.GetSection(jsonSection).Get<TestSettings>().AppPath;
            Settings.AppPackage = configurationRoot.GetSection(jsonSection).Get<TestSettings>().AppPackage;
            Settings.AppActivity = configurationRoot.GetSection(jsonSection).Get<TestSettings>().AppActivity;
            Settings.AuthSecret = configurationRoot.GetSection(jsonSection).Get<TestSettings>().AuthSecret;
            Settings.BasePath = configurationRoot.GetSection(jsonSection).Get<TestSettings>().BasePath;
            Settings.ThreadSleepMultiplicator = configurationRoot.GetSection(jsonSection).Get<TestSettings>().ThreadSleepMultiplicator;
        }
    }
}
