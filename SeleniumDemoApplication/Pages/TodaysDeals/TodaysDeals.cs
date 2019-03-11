using OpenQA.Selenium;
using SeleniumDemoApplication.Events;
using SeleniumDemoApplication.Pages.ProductPrice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemoApplication.Pages.TodaysDeals
{
    class TodaysDeals
    {
        public void SelectProductPrice(IWebDriver driver) => driver.FindElement(todaysDealsElements.ClickonPriceLessthen25).Click();

        public void ClickOnDropDown(IWebDriver driver) => driver.FindElement(todaysDealsElements.clickOnDropDown).Click();

        public void ClickOnLowtohighPrice(IWebDriver driver) => driver.FindElement(todaysDealsElements.clickOnLowtoHigh).Click();

        public void ClickOnOrders(IWebDriver driver) => driver.JavaScriptClickElement(driver.FindElement(todaysDealsElements.clickOnOrders));

    }
}
