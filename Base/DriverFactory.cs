using AppiumFramework.Config;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Service;
using System;

namespace AppiumFramework.Base
{
    public class DriverFactory
    {
        private AppiumLocalService appiumLocalService;
        private static Lazy<DriverFactory> instance = new Lazy<DriverFactory>(() => new DriverFactory());

        public static DriverFactory Instance
        {
            get
            {
                return instance.Value;
            }
        } 

        private DriverFactory()
        {

        }

        public AppiumDriver<AppiumWebElement> AppiumDriver { get; set; }

        public void InitializeAndroidApp<T>() where T : AppiumDriver<AppiumWebElement>
        {
            var driverOptions = new AppiumOptions();
            driverOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, Settings.PlatformName);
            driverOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, Settings.DeviceName);
            driverOptions.AddAdditionalCapability(MobileCapabilityType.App, Settings.AppPath);
            driverOptions.AddAdditionalCapability("appPackage", Settings.AppPackage);
            driverOptions.AddAdditionalCapability("appActivity", Settings.AppActivity);
            driverOptions.AddAdditionalCapability("newCommandTimeout", 0);

            var builder = StartAppiumLocalService();
            AppiumDriver = new AndroidDriver<AppiumWebElement>(builder, driverOptions);
        }

        public AppiumLocalService StartAppiumLocalService()
        {
            appiumLocalService = new AppiumServiceBuilder().UsingAnyFreePort().Build();
            if (!appiumLocalService.IsRunning)
            {
                appiumLocalService.Start();
            }

            return appiumLocalService;
        }

        public AppiumLocalService StartAppiumLocalService(int portNumber)
        {
            appiumLocalService = new AppiumServiceBuilder().UsingPort(portNumber).Build();
            if (!appiumLocalService.IsRunning)
            {
                appiumLocalService.Start();
            }

            return appiumLocalService;
        }

        public void CloseAppiumServer()
        {
            AppiumDriver.CloseApp();
        }
    }
}
