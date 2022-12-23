using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace Lab8.pages
{
    public class BasePage
    {
        private TimeSpan timeout = new TimeSpan(3000);
        
        protected Actions action;
        protected WebDriver driver;
        protected WebDriverWait wait;

        public BasePage(WebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, timeout);
            action = new Actions(driver);
        }

        protected void WaitForElementToAppear(By Xpath)
        {
            wait.Until(drv => drv.FindElement(Xpath));
        }
    }
}
