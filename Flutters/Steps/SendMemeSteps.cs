using AppiumFramework.Base;
using Flutters.Base;
using Flutters.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Flutters.Steps
{
    [Binding]
    public class SendMemeSteps
    {
        [When(@"I click the SEND MEME button")]
        public void WhenIClickTheSENDMEMEButton()
        {
            PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<HomePage>().GotoSendMemePage();
        }

        [When(@"I add a title and a photo from gallery")]
        public void WhenIAddATitleAndAPhotoFromGallery()
        {
            PageFactory.Instance.CurrentPage.As<SendMemePage>().AddTitle();
            PageFactory.Instance.CurrentPage.As<SendMemePage>().AddPictureFromGallery();
        }

        [When(@"I click the POST button")]
        public void WhenIClickThePOSTButton()
        {
            PageFactory.Instance.CurrentPage.As<SendMemePage>().ClickPostUploadButton();
        }

        [Then(@"the number of posts in Database Table Posts is incremented")]
        public void ThenTheNumberOfPostsInDatabaseTablePostsIsIncremented()
        {
            //
        }

    }
}
