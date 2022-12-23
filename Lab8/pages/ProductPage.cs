using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.pages
{
    public class ProductPage : BasePage
    {
        private By _addToSavedButtonBy = By.XPath("//*[contains(@id, \"save-for-later-portal\")]/button");

        public ProductPage(WebDriver driver) : base(driver) { }

        public SavedSuccessfully AddToSaved()
        {
            driver.FindElement(_addToSavedButtonBy).Click();
            return new SavedSuccessfully(driver);
        }
    }
    public class SavedSuccessfully : BasePage
    {
        private By _actualAriaLabelBy = By.XPath("//*[contains(@id, \"save-for-later-portal\")]/button");
        
        public SavedSuccessfully(WebDriver driver) : base(driver) { }

        public string GetActualAriaLabel()
        {
            return driver.FindElement(_actualAriaLabelBy).GetAttribute("aria-label");
        }
    }
}
