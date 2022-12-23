using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.pages
{
    public class SearchResultPage : BasePage
    {
       
        private By searchResultMessageBy = By.XPath("//*[@id=\"search-term-banner\"]/p[1]");
        private By searchedWordBy = By.XPath("//*[@id=\"search-term-banner\"]/p[2]");

        public SearchResultPage(WebDriver driver) : base(driver) { }

        public FullSearchResultMessage GetActualMessage()
        {
            FullSearchResultMessage fullMessage = new FullSearchResultMessage(
                driver.FindElement(searchResultMessageBy).Text,
                driver.FindElement(searchedWordBy).Text);
            return fullMessage;
        }
    }
}
