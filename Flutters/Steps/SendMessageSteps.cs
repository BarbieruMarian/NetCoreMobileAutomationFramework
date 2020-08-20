using AppiumFramework.Base;
using AppiumFramework.Utilities;
using Flutters.Base;
using Flutters.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Flutters.Steps
{
    [Binding]
    public class SendMessageSteps : TestStep
    {
        private string messageSendFromUI { get; set; }
        [Given(@"I go to the chats page")]
        public void GivenIGoToTheChatsPage()
        {
            PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<HomePage>().GotoChatPage();
            FrameworkUtilities.Sleep(1000);

            PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<ChatPage>().GotoHomePage();
            FrameworkUtilities.Sleep(1000);

            PageFactory.Instance.CurrentPage = PageFactory.Instance.CurrentPage.As<HomePage>().GotoChatPage();
            FrameworkUtilities.Sleep(1000);
            Assert.That(PageFactory.Instance.CurrentPage.As<ChatPage>().IsChatPage, Is.True, "You are not on the settings page");
        }

        [Given(@"I select first person from chats")]
        public void GivenISelectFirstPersonFromChats()
        {
            PageFactory.Instance.CurrentPage.As<ChatPage>().ClickFirstPersonInChats();
        }

        [When(@"I send him a message")]
        public void WhenISendHimAMessage()
        {
            PageFactory.Instance.CurrentPage.As<ChatPage>().SendMessage();
            messageSendFromUI = PageFactory.Instance.CurrentPage.As<ChatPage>().Message;
        }

        [Then(@"that user recives it and this can be proven by checking the database")]
        public void ThenThatUserRecivesItAndThisCanBeProvenByCheckingTheDatabase()
        {
            var databaseMessageInfo = GetLastChatMessage();
            if (databaseMessageInfo.Message == messageSendFromUI) { }
            else Assert.Fail($"Expected message: {messageSendFromUI} but database message is {databaseMessageInfo.Message}");
        }

    }
}
