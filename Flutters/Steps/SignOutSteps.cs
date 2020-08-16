using AppiumFramework.Base;
using AppiumFramework.Utilities;
using Flutters.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Flutters.Steps
{
    [Binding]
    public class SignOutSteps
    {
        [When(@"I navigate to settings page")]
        public void WhenINavigateToSettingsPage()
        {
            PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<HomePage>().GotoSettingsPage();
            Assert.That(PageFactory.Instance.CurrentPage.As<SettingsPage>().IsSettingsPage, Is.True, "You are not on the settings page");
        }

        [When(@"I press the Sign Out Button")]
        public void WhenIPressTheSignOutButton()
        {
            PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<SettingsPage>().SignOut();
        }

        [Then(@"the application is closed and the screen goes back to the login screen")]
        public void ThenTheApplicationIsClosedAndTheScreenGoesBackToTheLoginScreen()
        {
            FrameworkUtilities.Sleep(2000);
            PageFactory.Instance.CurrentPage.As<LoginPage>().IsSignInWithEmailExist();
        }
    }
}
