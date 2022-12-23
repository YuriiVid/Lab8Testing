using Lab8.pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class FullSearchResultMessage
    {
        public string ResultMessage;
        public string SearchedWord;

        public FullSearchResultMessage(string ResultMessage, string SearhedWord)
        {
            this.ResultMessage = ResultMessage;
            this.SearchedWord = SearhedWord;
        }
    }

    public class BaseTest
    {
        protected WebDriver driver;
        private static string OSCOMMERCE_URL = "https://www.asos.com/women";

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = OSCOMMERCE_URL;
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
    public class AddToSavedTest : BaseTest
    {
        private static string AriaLabelSuccess = "Item saved";

        [Test]
        public void addToSavedTest()
        {
            string ActualAriaLabel = new HomePage(driver)
                .GoToJeansPage()
                .GoToProductPage()
                .AddToSaved()
                .GetActualAriaLabel();
            Assert.True(ActualAriaLabel == AriaLabelSuccess);
        }
    }

    public class IsShoppingCountrySwitchingTest : BaseTest
    {
        private static string AltSuccess = "United States";

        [Test]
        public void isShoppingCountrySwitchingTest()
        {
            string ActualAlt = new HomePage(driver)
                .ClickOnCountryIcon()
                .SelectCountryUSA()
                .GetActualIconAlt();
            Assert.True(ActualAlt == AltSuccess);
        }
    }

    public class IsSearchWorkingTest : BaseTest
    {
        private static FullSearchResultMessage successMessage = new FullSearchResultMessage("Your search results for:", "Glasses");

        [Test]
        public void isSearchWorkingTest()
        {
            FullSearchResultMessage ActualSearchResultMessage = new HomePage(driver)
                .SearchForGlasses()
                .GetActualMessage();
            Assert.True(ActualSearchResultMessage.SearchedWord.Contains(successMessage.SearchedWord) 
                && ActualSearchResultMessage.ResultMessage.Contains(successMessage.ResultMessage));
        }
    }


}
