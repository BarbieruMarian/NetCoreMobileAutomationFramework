using AppiumFramework.Base;
using AppiumFramework.Utilities;
using Flutters.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Flutters.Steps
{
    [Binding]
    public class BottomMenusNavSteps
    {
        [Then(@"I click the Settings Tab")]
        public void ThenIClickTheSettingsTab()
        {
            PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<HomePage>().GotoSettingsPage();
            FrameworkUtilities.Sleep(1000);
            Assert.That(PageFactory.Instance.CurrentPage.As<SettingsPage>().IsSettingsPage, Is.True, "You are not on the settings page");
        }

        [When(@"I keep changing the tabs many times")]
        public void WhenIKeepChangingTheTabsManyTimes()
        {
            for (int i = 0; i < 50; i++)
            {
                FrameworkUtilities.Sleep(1000);

                PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<SettingsPage>().GotoHomePage();
                FrameworkUtilities.Sleep(1000);
                PageFactory.Instance.CurrentPage.As<HomePage>().IsHomePage();

                PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<HomePage>().GotoChatPage();
                FrameworkUtilities.Sleep(1000);
                PageFactory.Instance.CurrentPage.As<ChatPage>().IsChatPage();

                PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<ChatPage>().GotoProfilePage();
                FrameworkUtilities.Sleep(1000);
                PageFactory.Instance.CurrentPage.As<ProfilePage>().IsProfilePage();

                PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<ProfilePage>().GotoSettingsPage();
                FrameworkUtilities.Sleep(1000);
                PageFactory.Instance.CurrentPage.As<SettingsPage>().IsSettingsPage();
            }
        }

        [Then(@"I go back to the Home Page")]
        public void ThenIGoBackToTheHomePage()
        {
            FrameworkUtilities.Sleep(1500);

            PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<SettingsPage>().GotoHomePage();
            FrameworkUtilities.Sleep(1500);
            Assert.That(PageFactory.Instance.CurrentPage.As<HomePage>().IsHomePage, Is.True, "You are not on the home page");
        }
    }
}
