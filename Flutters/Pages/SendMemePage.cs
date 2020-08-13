using Flutters.Base;
using OpenQA.Selenium.Appium;

namespace Flutters.Pages
{
    public class SendMemePage : Navigation
    {
        AppiumWebElement ParagraphTitle => AppiumDriver.FindElementById("com.RLD.newmemechat:id/pTitleEt");
        AppiumWebElement SelectImage => AppiumDriver.FindElementById("com.RLD.newmemechat:id/pImageIv");
        AppiumWebElement GoBack => AppiumDriver.FindElementById("‎‏‎‎‎‎‎‏‎‏‏‏‎‎‎‎‎‏‎‎‏‎‎‎‎‏‏‏‏‏‎‏‏‎‏‏‎‎‎‎‏‏‏‏‏‏‏‎‏‏‏‏‏‎‏‎‎‏‏‎‏‎‎‎‎‎‏‏‏‎‏‎‎‎‎‎‏‏‎‏‏‎‎‏‎‏‎‏‏‏‏‏‎‎Navigate up‎");
        AppiumWebElement CameraUpload => AppiumDriver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/androidx.appcompat.widget.LinearLayoutCompat/android.widget.FrameLayout/android.widget.ListView/android.widget.TextView[1]");
        AppiumWebElement GaleryUpload => AppiumDriver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/androidx.appcompat.widget.LinearLayoutCompat/android.widget.FrameLayout/android.widget.ListView/android.widget.TextView[2]");
        AppiumWebElement ConfirmUpload => AppiumDriver.FindElementById("com.RLD.newmemechat:id/pUploadBtn");

        public void ClickParagraphTitle()
        {
            ParagraphTitle.Click();
        }

        public void ClickSelectImage()
        {
            SelectImage.Click();
        }

        public void ClickGoBack()
        {
            GoBack.Click();
        }

        public void ClickCameraUpload()
        {
            CameraUpload.Click();
        }

        public void ClickGaleryUpload()
        {
            GaleryUpload.Click();
        }

        public void ClickConfirmUpload()
        {
            ConfirmUpload.Click();
        }

    }
}
