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
    public class SendMemeSteps : FirebaseExtension
    {

        public int PostCountBeforeTest { get; set; }
        public int PostCountAfterTest { get; set; }
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

            //var calls = await FirebaseClient
            //    .Child("Posts")
            //    .OnceAsync<Post>();

            //PostCount = calls.Count;

            Task<int> task = Task.Run<int>(async () => await GetNrPosts());
            PostCountBeforeTest = task.Result;

        }

        [When(@"I click the POST button")]
        public void WhenIClickThePOSTButton()
        {
            PageFactory.Instance.CurrentPage.As<SendMemePage>().ClickPostUploadButton();
        }

        [Then(@"the number of posts in Database Table Posts is incremented")]
        public  void ThenTheNumberOfPostsInDatabaseTablePostsIsIncremented()
        {

            Task<int> task = Task.Run<int>(async () => await GetNrPosts());
            PostCountAfterTest = task.Result;

            if (PostCountAfterTest == PostCountBeforeTest + 1)
            {

            }
            else Assert.Fail("test failed");
        }

        public async Task<int> GetNrPosts()
        {
            var calls = await FirebaseClient
                .Child("Posts")
                .OnceAsync<Post>();

            return calls.Count;
        }

    }
}
