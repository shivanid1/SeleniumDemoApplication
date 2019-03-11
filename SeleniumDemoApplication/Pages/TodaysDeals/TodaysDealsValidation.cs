using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumDemoApplication.Pages.ProductPrice;

namespace SeleniumDemoApplication.Pages.TodaysDeals
{
    class TodaysDealsValidation
    {

        public void todaysDealProductDisplayed(IWebDriver driver) => Assert.True(driver.FindElement(todaysDealsElements.priceField).Displayed, "Price of Product is not Displayed.");

        public void priceOfProductDisplayed(IWebDriver driver) => Assert.True(driver.FindElement(todaysDealsElements.checkProductPrice).Displayed, "Products of price displayed.");

        public void checkProductPrice(IWebDriver driver)  => Assert.True(Convert.ToInt32((Regex.Split(driver.FindElement(todaysDealsElements.checkProductPrice).Text, @"\D+"))[1]) < 25, "The Price of Product does not match");

        public void checkSortByLink(IWebDriver driver) => Assert.True(driver.FindElement(todaysDealsElements.sortByPrice).Displayed, "Sort By Link is not Displayed.");

        public void checkPriceOptions(IWebDriver driver) => Assert.True(driver.FindElement(todaysDealsElements.lowtohighPrice).Displayed, "Low to High Option is not Displayed. ");

        public  void checkLowestPriceProdust(IWebDriver driver) => Assert.True(Convert.ToInt32((Regex.Split(driver.FindElement(todaysDealsElements.lowestPriceProdust).Text, @"\D+"))[1]) < 1, "Low to high Price Products are not displayed.");

        public  void checktheOrders(IWebDriver driver) => Assert.True(driver.FindElement(todaysDealsElements.checkOrders).Displayed, "Product orders are not Displayed.");

        public void checkHeader(IWebDriver driver) => Assert.True(driver.FindElement(todaysDealsElements.checkHeader).Displayed, "Header is not Displayed.");
       
        public void checkFooter(IWebDriver driver) => Assert.True(driver.FindElement(todaysDealsElements.checkFooter).Displayed, "Footer is not Displayed.");

    }
}
