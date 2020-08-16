using AppiumFramework.Base;
using AppiumFramework.Config;
using Firebase.Database;
using Flutters.Base;
using Flutters.Database.Models;
using Flutters.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Firebase.Database.Query;
using NUnit.Framework;
using AppiumFramework.Utilities;

namespace Flutters.Steps
{
    [Binding]
    public class SendMemeSteps : TestStep
    {

        private int postCountBeforeTest { get; set; }
        private int postCountAfterTest { get; set; }
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
            postCountBeforeTest = GetNumberOfPosts();
        }

        [When(@"I click the POST button")]
        public void WhenIClickThePOSTButton()
        {
            PageFactory.Instance.CurrentPage.As<SendMemePage>().ClickPostUploadButton();
        }

        [Then(@"the number of posts in Database Table Posts is incremented")]
        public  void ThenTheNumberOfPostsInDatabaseTablePostsIsIncremented()
        {
            postCountAfterTest = GetNumberOfPosts();
            if (postCountAfterTest == postCountBeforeTest + 1) { }
            else Assert.Fail("test failed");
        }
    }
}
