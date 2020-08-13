using Flutters.Base;
using OpenQA.Selenium.Appium;

namespace Flutters.Pages
{
    public class ProfilePage : Navigation
    {
        AppiumWebElement Profile => AppiumDriver.FindElementByXPath("//android.widget.LinearLayout[@content-desc=\"Profile\"]");
        AppiumWebElement Users => AppiumDriver.FindElementByXPath("//android.widget.LinearLayout[@content-desc=\"Users\"]");

        public bool IsProfilePage()
        {
            return ProfileTab.Selected;
        }
    }
}
