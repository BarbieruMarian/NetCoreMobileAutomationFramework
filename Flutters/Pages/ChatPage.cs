using AppiumFramework.Utilities;
using Flutters.Base;
using OpenQA.Selenium.Appium;
using System;

namespace Flutters.Pages
{
    public class ChatPage : Navigation
    {
        AppiumWebElement UpperChatText => AppiumDriver.FindElementByXPath("//android.widget.LinearLayout[@content-desc=\"Chats\"]");
        AppiumWebElement SendMessageTextbox => AppiumDriver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.LinearLayout[2]/android.widget.ScrollView/android.widget.EditText");
        AppiumWebElement FirstPersonInChats => AppiumDriver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.RelativeLayout[1]/androidx.viewpager.widget.ViewPager/android.widget.RelativeLayout/androidx.recyclerview.widget.RecyclerView/android.widget.RelativeLayout[1]");
        AppiumWebElement SendMessageButton => AppiumDriver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.ImageButton[2]");

        public string Message { get; set; }

        public void ClickFirstPersonInChats()
        {
            FirstPersonInChats.Click();
            FrameworkUtilities.Sleep(1000);
        }

        public void SendMessage()
        {
            ClickSendMessageTextbox();
            GenerateRandomMessage();
            SendMessageTextbox.SendKeys(Message);
            FrameworkUtilities.Sleep(1000);
            SendMessageButton.Click();
        }

        public void GenerateRandomMessage()
        {
            var randomID = new Random().Next(1, 100);
            Message = "Message" + randomID.ToString();
        }

        private void ClickSendMessageTextbox()
        {
            SendMessageTextbox.Click();
        }
        public bool IsChatPage()
        {
            return ChatTab.Selected;
        }
    }
}
