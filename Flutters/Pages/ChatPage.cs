using Flutters.Base;
using OpenQA.Selenium.Appium;

namespace Flutters.Pages
{
    public class ChatPage : Navigation
    {
        AppiumWebElement UpperChatText => AppiumDriver.FindElementByXPath("//android.widget.LinearLayout[@content-desc=\"Chats\"]");

        public bool IsChatPage()
        {
            return ChatTab.Selected;
        }
    }
}
