using AppiumFramework.Base;
using Flutters.Base;
using Flutters.Database.Models;
using Flutters.Pages;
using TechTalk.SpecFlow;
using NUnit.Framework;

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
            postTitle = PageFactory.Instance.CurrentPage.As<SendMemePage>().PostTitle;
            PageFactory.Instance.CurrentPage.As<SendMemePage>().AddPictureFromGallery();
            postBeforeSendingPicture = GetLastPostTable();
        }

        [When(@"I click the POST button")]
        public void WhenIClickThePOSTButton()
        {
            PageFactory.Instance.CurrentPage.As<SendMemePage>().ClickPostUploadButton();
            postAfterSendingPicture = GetLastPostTable();
        }

        [Then(@"the ID of this new post is different from the last one")]
        public void ThenTheIDOfThisNewPostIsDifferentFromTheLastOne()
        {
            if (postBeforeSendingPicture.PId != postAfterSendingPicture.PId) { }
            else Assert.Fail("The postId it's not different from the previous one");
        }

        [Then(@"the Title of this new post is different from the last one")]
        public void ThenTheTitleOfThisNewPostIsDifferentFromTheLastOne()
        {
            if (postBeforeSendingPicture.PTitle != postAfterSendingPicture.PTitle) { }
            else Assert.Fail("The title for the current post is identical with the previous one");
        }

        [Then(@"the Title of this new post is indeed the one which was typed in this testrun")]
        public void ThenTheTitleOfThisNewPostIsIndeedTheOneWhichWasTypedInThisTestrun()
        {
            if (postAfterSendingPicture.PTitle == postTitle) { }
            else Assert.Fail("The title of the last post is not the same as the one which was typed in this current test run");
        }

        [Then(@"I delete the last post genereted by this testrun and the corespondent image")]
        public void ThenIDeleteTheLastPostGeneretedByThisTestrunAndTheCorespondentImage()
        {
            DeleteLastPostTable(postAfterSendingPicture.PId);
        }

    }
}
