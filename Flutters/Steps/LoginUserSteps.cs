using AppiumFramework.Base;
using AppiumFramework.Config;
using AppiumFramework.Utilities;
using Flutters.Pages;
using NUnit.Framework;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Flutters.Steps
{
    [Binding]
    public class LoginUserSteps
    {
        [Given(@"I launch the application")]
        public void GivenILaunchTheApplication()
        {
            PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.GetInstance<LoginPage>();
        }

        [Given(@"I choose Sign in with Email")]
        public void GivenIChooseSignInWithEmail()
        {
            FrameworkUtilities.Sleep(1000);
            Assert.That(PageFactory.Instance.CurrentPage.As<LoginPage>().IsSignInWithEmailExist, Is.True, "Login with email button was not found");
            PageFactory.Instance.CurrentPage.As<LoginPage>().ClickEmailSignIn();
        }

        [When(@"I enter the username and password as")]
        public void WhenIEnterTheUsernameAndPasswordAs(Table table)
        {
            FrameworkUtilities.Sleep(1000);
            dynamic data = table.CreateDynamicInstance();
            PageFactory.Instance.CurrentPage.As<LoginPage>().EmailSignInWithExistingAccount((string)data.Username, (string)data.Password);
        }

        [When(@"I click the Login Button")]
        public void WhenIClickTheLoginButton()
        {
            FrameworkUtilities.Sleep(1000);
            PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<LoginPage>().SignInUser();
        }

        [Then(@"I see the homepage")]
        public void ThenISeeTheHomepage()
        {
            FrameworkUtilities.Sleep(5000);
            Assert.That(PageFactory.Instance.CurrentPage.As<HomePage>().IsHomePage, Is.True, "Hot Button was not found - you are probably not on the home page");
        }
    }
}
