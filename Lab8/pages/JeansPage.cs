using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.pages
{
    public class JeansPage : BasePage
    {
        private By productLinkBy = By.XPath("//article[2]/a");

        public JeansPage(WebDriver driver) : base(driver) { }

        public ProductPage GoToProductPage()
        {
            driver.FindElement(productLinkBy).Click();
            return new ProductPage(driver);
        }

    }
}
