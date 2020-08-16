using Flutters.Base;
using OpenQA.Selenium.Appium;
using System.Collections.Generic;
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
        AppiumWebElement AllowGalleryAccess => AppiumDriver.FindElementById("com.android.packageinstaller:id/permission_allow_button");
        AppiumWebElement CameraDownloadsSection => AppiumDriver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.support.v7.widget.RecyclerView/android.widget.RelativeLayout[2]");
        ReadOnlyCollection<AppiumWebElement> DownloadPictures => AppiumDriver.FindElementsByClassName("android.view.ViewGroup");
        AppiumWebElement PostButton => AppiumDriver.FindElementById("com.RLD.newmemechat:id/pUploadBtn");


        public void AddTitle()
        {
            ParagraphTitle.Click();
            Thread.Sleep(500);
            ParagraphTitle.SendKeys("TestTitle");  
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
            ClickSelectImage();
            Thread.Sleep(500);

            GaleryUpload.Click();
            Thread.Sleep(500);

            AllowGalleryAccess.Click();
            Thread.Sleep(500);

            CameraDownloadsSection.Click();
            Thread.Sleep(500);

            ClickFirstImage();
            Thread.Sleep(500);
        }


        public void ClickPostUploadButton()
        {
            PostButton.Click();
        }
        public void ClickFirstImage()
        {
            var firstImage = GetFirstImage();
            firstImage.Click();
        }
        public AppiumWebElement GetFirstImage()
        {
            var firstPic = DownloadPictures[0];
            Thread.Sleep(500);
            return firstPic;
        }
    }
}
