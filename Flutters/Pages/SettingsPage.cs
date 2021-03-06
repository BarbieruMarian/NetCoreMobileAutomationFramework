﻿using AppiumFramework.Utilities;
using Flutters.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using System;
using System.IO;

namespace Flutters.Pages
{
    public class SettingsPage : Navigation
    {
        AppiumWebElement ThemeChange => AppiumDriver.FindElementById("com.RLD.newmemechat:id/themeSwitch");
        AppiumWebElement SignOutButton => AppiumDriver.FindElementById("com.RLD.newmemechat:id/btn_sign_out");


        public LoginPage SignOut()
        {
            var loginInstance = GetInstance<LoginPage>();
            SignOutButton.Click();
            return loginInstance;
        }

        public bool IsSettingsPage()
        {
            return SettingsTab.Selected;
        }

        public bool IsThemeChangedEnabled()
        {
            return !ThemeChange.Selected;
        }

        public void ToggleNightMode()
        {
            FrameworkUtilities.Sleep(500);
            ThemeChange.Click();
        }

        public byte[] TakeScreenshot()
        {
            return AppiumDriver.GetScreenshot().AsByteArray;
        }

    }
}

