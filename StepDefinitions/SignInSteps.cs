using GiftreteCommunityProject.PageObjects;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace GiftreteCommunityProject.StepDefinitions
{
    [Binding]
    public class SignInSteps
    {

        SignInPO signInPO;

        public SignInSteps()
        {
            signInPO = new SignInPO ();
        }

        [Given(@"I navigate to site ""(.*)""")]
        public void GivenINavigateToSite(string url)
        {
            signInPO.NavigateToSite(url);
        }
        
        [Given(@"I click on sign in")]
        public void GivenIClickOnSignIn()
        {
            signInPO.ClickSignIn();
        }
        
        [When(@"I enter email and password")]
        public void WhenIEnterEmailAndPassword(Table table)
        {
            var emailAndPassword = table.CreateInstance<Details>();

            string email = emailAndPassword.Email;
            string password = emailAndPassword.Password;

            signInPO.EnterEmailAndPassword(email, password);
        }
        
        [When(@"I click sign in")]
        public void WhenIClickSignIn()
        {
            signInPO.ClickSecondSignIn();
        }
        
        [Then(@"my home page should be displayed")]
        public void ThenMyHomePageShouldBeDisplayed()
        {
            
        }

        [Then(@"I sign out")]
        public void ThenISignOut()
        {
            signInPO.ClickLogOut();
        }

    }
}
