using AppiumFramework.Base;
using Flutters.Pages;
using NUnit.Framework;
using System.Threading;
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
            Assert.That(PageFactory.Instance.CurrentPage.As<SettingsPage>().IsSettingsPage, Is.True, "Sign out button was not found - you are probably not on the settings page");
        }

        [When(@"I keep changing the tabs many times")]
        public void WhenIKeepChangingTheTabsManyTimes()
        {
            for (int i = 0; i < 50; i++)
            {
                Thread.Sleep(2000);

                PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<SettingsPage>().GotoChatPage();
                Thread.Sleep(2000);
                PageFactory.Instance.CurrentPage.As<ChatPage>().IsChatPage();

                PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<ChatPage>().GotoProfilePage();
                Thread.Sleep(2000);
                PageFactory.Instance.CurrentPage.As<ProfilePage>().IsProfilePage();

                PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<ProfilePage>().GotoSettingsPage();
                Thread.Sleep(2000);
                PageFactory.Instance.CurrentPage.As<SettingsPage>().IsSettingsPage();
            }
        }

        [Then(@"I go back to the Home Page")]
        public void ThenIGoBackToTheHomePage()
        {
            Thread.Sleep(2000);

            PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<SettingsPage>().GotoHomePage();
            Thread.Sleep(2000);
            Assert.That(PageFactory.Instance.CurrentPage.As<HomePage>().IsHomePage, Is.True, "Hot button was not found - you are probably not on the home page");
        }
    }
}
