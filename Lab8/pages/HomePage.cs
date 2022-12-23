using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab8.pages
{
    public class HomePage : BasePage
    {
        private By searchBarBy = By.XPath("//*[@id=\"chrome-search\"]");
        private By searchButtonBy = By.XPath("//*[@id=\"search-icon\"]/ancestor::button");
        private By clothingButtonBy = By.XPath("//button[@data-id=\"96b432e3-d374-4293-8145-b00772447cde\"]");
        private By jeansButtonBy = By.XPath("//*[@id=\"96b432e3-d374-4293-8145-b00772447cde\"]/div/div[2]/div/div[1]/ul/li[13]/a");
        private By countrySelectorButtonBy = By.XPath("//div[@class= \"_25L--Pi\"]");
        private By countryIcon = By.XPath("//div[@class= \"_25L--Pi\"]/button/img");

        public HomePage(WebDriver driver) : base(driver) {}
        
        public JeansPage GoToJeansPage()
        {
            action.MoveToElement(driver.FindElement(clothingButtonBy)).Perform();
            driver.FindElement(jeansButtonBy).Click();
            return new JeansPage(driver);
        }
        
        public SearchResultPage SearchForGlasses()
        {
            driver.FindElement(searchBarBy).SendKeys("Glasses");
            driver.FindElement(searchButtonBy).Click();
            return new SearchResultPage(driver);
        }
        
        public PopupWindow ClickOnCountryIcon()
        {
            driver.FindElement(countrySelectorButtonBy).Click();
            return new PopupWindow(driver);
        }

        public string GetActualIconAlt()
        {
            return driver.FindElement(countryIcon).GetAttribute("alt");
        }
    }
}
