using Flutters.Base;
using OpenQA.Selenium.Appium;
using System.Collections.Generic;
using System;
using System.Collections.ObjectModel;
using System.Threading;

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
        public string myNumber { get; set; }
        public string postTitle()
        {
            myNumber= generateRandomNumber().ToString();
            return "TestTitle" + myNumber;
        }


        public int generateRandomNumber()
        {
            Random rnd = new Random();
            return rnd.Next(1,100);
        }

        

        public void AddTitle()
        {
            Thread.Sleep(2000);
            ParagraphTitle.Click();
            Thread.Sleep(500);
            ParagraphTitle.SendKeys(postTitle());  
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
            Thread.Sleep(2000);
            ClickSelectImage();

            Thread.Sleep(2000);
            GaleryUpload.Click();

            Thread.Sleep(2000);
            AllowGalleryAccess.Click();

            Thread.Sleep(2000);
            CameraDownloadsSection.Click();

            Thread.Sleep(2000);
            ClickFirstImage();


        }


        public void ClickPostUploadButton()
        {
            PostButton.Click();
        }
        public void ClickFirstImage()
        {
            Thread.Sleep(1000);
            var firstImage = GetFirstImage();
            firstImage.Click();
        }
        public AppiumWebElement GetFirstImage()
        {
            Thread.Sleep(2000);
            var firstPic = DownloadPictures[1];

            Thread.Sleep(500);
            return firstPic;
        }
    }
}
