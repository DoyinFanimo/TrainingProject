using GiftreteCommunityProject.PageObjects;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace GiftreteCommunityProject.StepDefinitions
{
    [Binding]
    public class CreateCommunitySteps
    {
        CreateCommunityPO createCommunityPO;
        public CreateCommunitySteps()
        {
            createCommunityPO = new CreateCommunityPO();
        }

        [When(@"I click on community")]
        public void WhenIClickOnCommunity()
        {
            createCommunityPO.ClickCommunity();
        }
        
        [When(@"I click create")]
        public void WhenIClickCreate()
        {
            createCommunityPO.ClickCreate();
        }
        
        [When(@"I enter community name ""(.*)""")]
        public void WhenIEnterCommunityName(string cName)
        {
            createCommunityPO.EnterCommName(cName);
        }
        
        [When(@"I select community type ""(.*)""")]
        public void WhenISelectCommunityType(string cType)
        {
            createCommunityPO.SelectCommunityType(cType);
        }
        
        [When(@"I enter community handle ""(.*)""")]
        public void WhenIEnterCommunityHandle(string cHandle)
        {
            createCommunityPO.EnterCommunityHandle(cHandle);
        }
        
        [When(@"I enter community description ""(.*)""")]
        public void WhenIEnterCommunityDescription(string cDescription)
        {

            createCommunityPO.EnterCommunityescription(cDescription);
        }
        
        [When(@"I select category ""(.*)""")]
        public void WhenISelectCategory(string cCategory)
        {
            createCommunityPO.SelectCategory(cCategory);
        }
        
        [When(@"I enter location ""(.*)""")]
        public void WhenIEnterLocation(string cLocation)
        {
            createCommunityPO.EnterLocation(cLocation);
        }
        
        

        [When(@"I upload an Image ""(.*)""")]
        public void WhenIUploadAnImage(string filename)
        {
            createCommunityPO.UploadImage(filename);
        }


        [When(@"I click create community")]
        public void WhenIClickCreateCommunity()
        {
            createCommunityPO.ClickCreateCommunity();
        }
        
        [Then(@"my community should be created")]
        public void ThenMyCommunityShouldBeCreated()
        {
          
        }

        [Then(@"display error message ""(.*)""")]
        public void ThenDisplayErrorMessage(string msg)
        {
            Assert.AreEqual(msg, createCommunityPO.GetErrMsgText());
        }

    }
}
