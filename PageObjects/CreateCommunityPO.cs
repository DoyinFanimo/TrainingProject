using GiftreteCommunityProject.Hooks;
using GiftreteCommunityProject.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftreteCommunityProject.PageObjects
{
    class CreateCommunityPO
    {
        IWebDriver driver;

        Waits waits;

        public CreateCommunityPO()
        {
            driver = Hook.driver;
            waits = new Waits();
        }

        IWebElement headerCommunity => driver.FindElement(By.XPath("(//span[@class='mm-text'])[2]"));
        IWebElement headerCreate => driver.FindElement(By.XPath("//*[@id='content']/div/div/div/div/div/ul/a[1]"));
        IWebElement communityName => driver.FindElement(By.Id("name"));
        IWebElement communityType => driver.FindElement(By.CssSelector("div > div > div  div > div > div > div > form > div > label:nth-child(4)"));
        IWebElement communityHandle => driver.FindElement(By.Id("cleanname"));
        IWebElement communityDescription => driver.FindElement(By.XPath("/html"));
        IWebElement category => driver.FindElement(By.XPath("//*[@id='group_type_id']"));
        IWebElement location => driver.FindElement(By.XPath("//*[@id='autocomplete']"));
        IWebElement image => driver.FindElement(By.XPath("//*[@id='files']"));
        IWebElement createComm => driver.FindElement(By.XPath("//*[@id='btn_create']"));
        IWebElement errMsg => driver.FindElement(By.Id("dng_msg_t"));
       
        public string GetErrMsgText()
        {
            return waits.WaitForElement(driver, errMsg).Text;
        }
        public void ClickCommunity()
        {
           waits.WaitForElement(driver, headerCommunity).Click();
        }

        public void ClickCreate()
        {
            headerCreate.Click();
        }

        public void EnterCommName(string cName)
        {
            communityName.SendKeys(cName);
        }

        public void SelectCommunityType(string cType)
        {
            communityType.Click();
        }

        public void EnterCommunityHandle(string cHandle)
        {
            communityHandle.SendKeys(cHandle);
        }

        public void EnterCommunityescription(string cDescription)
        {
            communityDescription.SendKeys(cDescription);
        }

        public void SelectCategory(string cCategory)
        {
            SelectElement sCategory = new SelectElement(category);
            sCategory.SelectByValue(cCategory);
        }

        public void EnterLocation(string cLocation)
        {
            location.SendKeys(cLocation);
        }

        public void UploadImage(string filename)
        {
           image.SendKeys("C:\\Users\\mclig\\source\\repos\\GiftreteCommunityProject\\Text Files\\fitnessImage.jfif");
        }

        public void ClickCreateCommunity()
        {
            createComm.Click();
        }
    }
}
