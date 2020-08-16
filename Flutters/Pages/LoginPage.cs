using AppiumFramework.Utilities;
using Flutters.Base;
using OpenQA.Selenium.Appium;

namespace Flutters.Pages
{
    public class LoginPage : Navigation
    {
        AppiumWebElement EmailSignIn => AppiumDriver.FindElementById("com.RLD.newmemechat:id/email_button");
        AppiumWebElement CancelPreviousUser => AppiumDriver.FindElementById("com.google.android.gms:id/cancel");
        AppiumWebElement EmailTextBox => AppiumDriver.FindElementById("com.RLD.newmemechat:id/email");
        AppiumWebElement NextButton => AppiumDriver.FindElementById("com.RLD.newmemechat:id/button_next");
        AppiumWebElement UsernameTextbox => AppiumDriver.FindElementById("com.RLD.newmemechat:id/name");
        AppiumWebElement PasswordTextBox => AppiumDriver.FindElementById("com.RLD.newmemechat:id/password");
        AppiumWebElement CreateUser => AppiumDriver.FindElementById("com.RLD.newmemechat:id/button_create");
        AppiumWebElement SignIn => AppiumDriver.FindElementById("com.RLD.newmemechat:id/button_done");
     
        internal HomePage CreateNewUserViaEmail(string email, string username, string password)
        {
            ClickEmailSignIn();
            ClickCancelPreviousUser();
            FillEmail(email);
            ClickNextButton();
            FillUsername(username);
            ClickCreateUser();
            FillPassword(password);
            ClickCreateUser();
            return new HomePage();

        }

        internal void EmailSignInWithExistingAccount(string email, string password)
        {
            FrameworkUtilities.Sleep(1000);
            FillEmail(email);
            ClickNextButton();
            FrameworkUtilities.Sleep(500);
            FillPassword(password);
        }

        internal void ClickEmailSignIn()
        {
            EmailSignIn.Click();
            FrameworkUtilities.Sleep(500);
        }

        internal void ClickCancelPreviousUser()
        {
            CancelPreviousUser.Click();
            FrameworkUtilities.Sleep(500);
        }

        internal void FillEmail(string email)
        {
            EmailTextBox.SendKeys(email);
            FrameworkUtilities.Sleep(500);
        }

        internal void ClickNextButton()
        {
            NextButton.Click();
            FrameworkUtilities.Sleep(500);
        }

        internal void FillUsername(string username)
        {
            UsernameTextbox.SendKeys(username);
            FrameworkUtilities.Sleep(500);
        }

        internal void FillPassword(string password)
        {
            PasswordTextBox.SendKeys(password);
            FrameworkUtilities.Sleep(500);
        }

        internal void ClickCreateUser()
        {
            CreateUser.Click();
            FrameworkUtilities.Sleep(500);
        }

        internal void ClickSignIn()
        {
            SignIn.Click();
            FrameworkUtilities.Sleep(500);
        }

        internal bool IsSignInWithEmailExist()
        {
            return EmailSignIn.Displayed;
        }

        internal HomePage SignInUser()
        {
            ClickSignIn();
            return GetInstance<HomePage>();
        }
    }
}
