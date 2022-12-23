using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.pages
{
    public class PopupWindow : HomePage
    {
        private By shopInDropDownBy = By.XPath("//*[@id=\"country\"]");
        private By updatePreferencesButtonBy = By.XPath("//*[@data-testid = \"save-country-button\"]");
        public PopupWindow(WebDriver driver) : base(driver) { }

        public HomePage SelectCountryUSA()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            new SelectElement(driver.FindElement(shopInDropDownBy)).SelectByText("United States");
            driver.FindElement(updatePreferencesButtonBy).Click();
            return new HomePage(driver);
        }
    }
}
