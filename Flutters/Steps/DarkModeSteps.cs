using AppiumFramework.Base;
using AppiumFramework.Utilities;
using Flutters.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Flutters.Steps
{
    [Binding]
    public class DarkModeSteps
    {
        public float LightModeBrightness { get; set; }
        public float DarkModeBrighness { get; set; }

        [When(@"I go to Settings page")]
        public void WhenIGoToSettingsPage()
        {
            PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<HomePage>().GotoSettingsPage();
            FrameworkUtilities.Sleep(1000);
            Assert.That(PageFactory.Instance.CurrentPage.As<SettingsPage>().IsSettingsPage, Is.True, "You are not on the settings page");
        }

        [When(@"I toggle the night mode")]
        public void WhenIToggleTheNightMode()
        {
            var byteArrayLightMode = PageFactory.Instance.CurrentPage.As<SettingsPage>().TakeScreenshot();
            LightModeBrightness = FrameworkUtilities.ImageBrightness(byteArrayLightMode);
            PageFactory.Instance.CurrentPage.As<SettingsPage>().ToggleNightMode();

            FrameworkUtilities.Sleep(1500);
            var byteArrayNightMode = PageFactory.Instance.CurrentPage.As<SettingsPage>().TakeScreenshot();
            DarkModeBrighness = FrameworkUtilities.ImageBrightness(byteArrayNightMode);
        }

        [Then(@"the toggle button change its state and is indeed toggled")]
        public void ThenTheToggleButtonChangeItsStateAndIsIndeedToggled()
        {
            Assert.That(PageFactory.Instance.CurrentPage.As<SettingsPage>().IsThemeChangedEnabled(), Is.True, "Dark theme switch was not toggled"); 
        }


        [Then(@"the theme changes to black")]
        public void AndTheThemeChangesToBlack()
        {
            if (LightModeBrightness > DarkModeBrighness) { }
            else Assert.Fail("Dark mode is actualy brighter than Light Mode!");
        }

        [Then(@"the dark theme brighness is not greater than (.*)")]
        public void ThenTheDarkThemeBrighnessIsNotGreaterThan(float p0)
        {
            if (DarkModeBrighness > p0)
            {
                Assert.Fail($"The image is not dark enough. Dark mode was not succesfully set. Expected: {p0} - Actual: {DarkModeBrighness}");
            }
        }

    }
}
