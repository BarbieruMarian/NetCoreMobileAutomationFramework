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
using System.Threading;

namespace Flutters.Steps
{
    [Binding]
    public class SendMemeSteps : TestStep
    {


        private string postTitle { get; set; }
        Post postBeforeSendingPicture = new Post();
        Post postAfterSendingPicture = new Post();

        [When(@"I click the SEND MEME button")]
        public void WhenIClickTheSENDMEMEButton()
        {
            PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<HomePage>().GotoSendMemePage();
        }

        [When(@"I add a title and a photo from gallery")]
        public void WhenIAddATitleAndAPhotoFromGallery()
        {
            PageFactory.Instance.CurrentPage.As<SendMemePage>().AddTitle();

            postTitle = PageFactory.Instance.CurrentPage.As<SendMemePage>().myNumber;

            PageFactory.Instance.CurrentPage.As<SendMemePage>().AddPictureFromGallery();
            postBeforeSendingPicture = GetPostTable();
        }

        [When(@"I click the POST button")]
        public void WhenIClickThePOSTButton()
        {
            PageFactory.Instance.CurrentPage.As<SendMemePage>().ClickPostUploadButton();
        }

        [Then(@"the postId in Database is different from previous one")]
        public  void ThenThePostIdInDatabaseIsDifferentFromPreviousOne()
        {

            postAfterSendingPicture = GetPostTable();
            
            Thread.Sleep(1000);
            if (postBeforeSendingPicture.PTitle!=postAfterSendingPicture.PTitle) 
            { 
                if(postBeforeSendingPicture.PId!=postAfterSendingPicture.PId)
                {
                    if(postAfterSendingPicture.PTitle==postTitle)
                    {
                       
                    }
                    else
                    {
                        Assert.Fail("The titles are different but the afterTitle it's not the same as sent title");
                    }
                }
                else
                {
                    Assert.Fail("The title is the same for before and after but the post ids are the same");
                }
            }
            else Assert.Fail("The postId it's not different from the previous one");
        }
    }
}
