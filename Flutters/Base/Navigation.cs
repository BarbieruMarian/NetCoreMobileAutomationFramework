using AppiumFramework.Base;
using Flutters.Pages;
using OpenQA.Selenium.Appium;

namespace Flutters.Base
{
    public class Navigation : BasePage
    {
        public AppiumWebElement HomeTab => AppiumDriver.FindElementById("com.RLD.newmemechat:id/home");
        public AppiumWebElement ChatTab => AppiumDriver.FindElementById("com.RLD.newmemechat:id/chat");
        public AppiumWebElement ProfileTab => AppiumDriver.FindElementById("com.RLD.newmemechat:id/profile");
        public AppiumWebElement SettingsTab => AppiumDriver.FindElementById("com.RLD.newmemechat:id/settings");

        public void ClickHome()
        {
            HomeTab.Click();
        }

        public void ClickChat()
        {
            ChatTab.Click();
        }

        public void ClickProfile()
        {
            ProfileTab.Click();
        }

        public void ClickSettings()
        {
            SettingsTab.Click();
        }

        internal ProfilePage GotoProfilePage()
        {
            var profileInstance = GetInstance<ProfilePage>();
            ClickProfile();
            return profileInstance;
        }

        internal ChatPage GotoChatPage()
        {
            var chatInstance = GetInstance<ChatPage>();
            ClickChat();
            return chatInstance;
        }

        internal SettingsPage GotoSettingsPage()
        {
            var settingsInstance = GetInstance<SettingsPage>();
            ClickSettings();
            return settingsInstance;
        }

        internal HomePage GotoHomePage()
        {
            var homepageInstance = GetInstance<HomePage>();
            ClickHome();
            return homepageInstance;
        }
    }
}
