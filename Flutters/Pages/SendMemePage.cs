using Flutters.Base;
using OpenQA.Selenium.Appium;
using System.Collections.Generic;
using System;
using System.Collections.ObjectModel;
using System.Threading;
using AppiumFramework.Utilities;

namespace Flutters.Pages
{
    public class SendMemePage : Navigation
    {
        AppiumWebElement ParagraphTitle => AppiumDriver.FindElementById("com.RLD.newmemechat:id/pTitleEt");
        AppiumWebElement SelectImage => AppiumDriver.FindElementById("com.RLD.newmemechat:id/pImageIv");
        AppiumWebElement GoBack => AppiumDriver.FindElementById("‎‏‎‎‎‎‎‏‎‏‏‏‎‎‎‎‎‏‎‎‏‎‎‎‎‏‏‏‏‏‎‏‏‎‏‏‎‎‎‎‏‏‏‏‏‏‏‎‏‏‏‏‏‎‏‎‎‏‏‎‏‎‎‎‎‎‏‏‏‎‏‎‎‎‎‎‏‏‎‏‏‎‎‏‎‏‎‏‏‏‏‏‎‎Navigate up‎");
        AppiumWebElement CameraUpload => AppiumDriver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/androidx.appcompat.widget.LinearLayoutCompat/android.widget.FrameLayout/android.widget.ListView/android.widget.TextView[1]");
        AppiumWebElement GaleryUpload => AppiumDriver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/androidx.appcompat.widget.LinearLayoutCompat/android.widget.FrameLayout/android.widget.ListView/android.widget.TextView[2]");
        AppiumWebElement AllowGalleryAccess => AppiumDriver.FindElementById("com.android.permissioncontroller:id/permission_allow_button");
        AppiumWebElement CameraDownloadsSection => AppiumDriver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.support.v7.widget.RecyclerView/android.widget.RelativeLayout[2]");
        ReadOnlyCollection<AppiumWebElement> DownloadPictures => AppiumDriver.FindElementsByClassName("android.view.ViewGroup");
        AppiumWebElement PostButton => AppiumDriver.FindElementById("com.RLD.newmemechat:id/pUploadBtn");
        public string PostTitle { get; set; }

        public void AddTitle()
        {
            FrameworkUtilities.Sleep(1000);
            ParagraphTitle.Click();
            FrameworkUtilities.Sleep(250);
            GenerateRandomPostTitle();
            ParagraphTitle.SendKeys(PostTitle);  
        }

        public void GenerateRandomPostTitle()
        {
            var randomID = new Random().Next(1, 100);
            PostTitle = "TestTitle" + randomID.ToString();
        }

        public void ClickSelectImage()
        {
            SelectImage.Click();
        }

        public void ClickGoBack()
        {
            GoBack.Click();
        }

        public void AddPictureFromGallery()
        {
            FrameworkUtilities.Sleep(1000);
            ClickSelectImage();

            FrameworkUtilities.Sleep(1000);
            GaleryUpload.Click();

            FrameworkUtilities.Sleep(1000);
            AllowGalleryAccess.Click();

            FrameworkUtilities.Sleep(1000);
            CameraDownloadsSection.Click();

            FrameworkUtilities.Sleep(1000);
            ClickFirstImage();
        }
        public void ClickPostUploadButton()
        {
            PostButton.Click();
        }

        public void ClickFirstImage()
        {
            FrameworkUtilities.Sleep(500);
            var firstImage = GetFirstImage();
            firstImage.Click();
        }

        public AppiumWebElement GetFirstImage()
        {
            FrameworkUtilities.Sleep(1000);
            var firstPic = DownloadPictures[1];

            FrameworkUtilities.Sleep(250);
            return firstPic;
        }
    }
}
