using Flutters.Base;
using OpenQA.Selenium.Appium;

namespace Flutters.Pages
{
    public class SettingsPage : Navigation
    {
        AppiumWebElement ThemeChange => AppiumDriver.FindElementById("com.RLD.newmemechat:id/themeSwitch");
        AppiumWebElement SignOut => AppiumDriver.FindElementById("com.RLD.newmemechat:id/btn_sign_out");

        public bool IsSettingsPage()
        {
            return SettingsTab.Selected;
        }
    }
}
