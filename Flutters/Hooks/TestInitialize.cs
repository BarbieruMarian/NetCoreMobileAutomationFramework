using AppiumFramework.Base;
using AppiumFramework.Config;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using TechTalk.SpecFlow;

namespace Flutters.Hooks
{
    [Binding]
    public class TestInitialize
    {
        [BeforeScenario]
        public void InitializeTest()
        {     
            ConfigReader.InitializeSettings();
            DriverFactory.Instance.InitializeAndroidApp<AppiumDriver<AppiumWebElement>>();
        }

        [TearDown]
        public void Cleanup()
        {
            DriverFactory.Instance.CloseAppiumServer();
        }
    }
}
