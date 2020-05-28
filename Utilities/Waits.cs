﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftreteCommunityProject.Utilities
{
    class Waits
    {
        public IWebElement WaitForElement(IWebDriver driver, IWebElement element)
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(10);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(500);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            if (fluentWait.Until(x => element.Displayed))
                return element;
            else
                return null;
        }
    }
}
