using Flutters.Base;
using OpenQA.Selenium.Appium;

namespace Flutters.Pages
{
    public class HomePage : Navigation
    {
        AppiumWebElement Hot => AppiumDriver.FindElementByXPath("//android.widget.LinearLayout[@content-desc=\"Hot\"]");
        AppiumWebElement ForYou => AppiumDriver.FindElementByXPath("//android.widget.LinearLayout[@content-desc=\"For You\"]");
        AppiumWebElement Like => AppiumDriver.FindElementById("com.RLD.newmemechat:id/upBtn");
        AppiumWebElement Dislike => AppiumDriver.FindElementById("com.RLD.newmemechat:id/dwnBtn");
        AppiumWebElement Comment => AppiumDriver.FindElementById("com.RLD.newmemechat:id/comBtn");
        AppiumWebElement Share => AppiumDriver.FindElementById("com.RLD.newmemechat:id/shareBtn");

        internal SendMemePage SendMeme()
        {
            ClickMemeButton();
            return GetInstance<SendMemePage>();
        }

        internal void ClickHot()
        {
            Hot.Click();
        }

        internal void ClickForYou()
        {
            ForYou.Click();
        }

        internal void ClickLike()
        {
            Like.Click();
        }

        internal void ClickDislike()
        {
            Dislike.Click();
        }
        public void ClickMemeButton()
        {
            SendMemeButton.Click();
        }

        public bool IsHomePage()
        {
            return HomeTab.Selected;
        }
    }
}
