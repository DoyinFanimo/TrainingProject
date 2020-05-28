using GiftreteCommunityProject.Hooks;
using GiftreteCommunityProject.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftreteCommunityProject.PageObjects
{
    class SignInPO
    {
        IWebDriver driver;

        Waits waits;
        public SignInPO()
        {
            driver = Hook.driver;
            waits = new Waits();
        }

        internal void NavigateToSite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        IWebElement signIn => driver.FindElement(By.CssSelector("div > div.pa0.flex.justify-end.dn.df-ns.ml7-m > a.sb-btn2"));

        IWebElement Eemail => driver.FindElement(By.XPath("//*[@id='user_email']"));

        IWebElement Epassword => driver.FindElement(By.CssSelector("#user_password"));

        IWebElement secondSignIn => driver.FindElement(By.CssSelector("#btn_signin"));

        IWebElement selectLogOut => driver.FindElement(By.XPath("/html/body/div[1]/header[1]/div/div[2]/div/div[3]/ul/li[3]/div"));

        IWebElement logout => driver.FindElement(By.XPath("/html/body/div[1]/header[1]/div/div[2]/div/div[3]/ul/li[3]/ul/li[3]/a"));

        public void ClickSignIn()
        {
            signIn.Click();
        }

        public void EnterEmailAndPassword(string email, string password)
        {
            Eemail.SendKeys(email);
            Epassword.SendKeys(password);
        }

        public void ClickSecondSignIn()
        {
            secondSignIn.Click();
        }

        public void ClickLogOut()
        {
           selectLogOut.Click();
           logout.Click();
        }
    }
}
