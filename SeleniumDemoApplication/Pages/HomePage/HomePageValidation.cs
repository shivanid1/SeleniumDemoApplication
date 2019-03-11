using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumDemoApplication.Page_Elements;

namespace SeleniumDemoApplication.Pages.HomePage
{
    class HomePageValidation
    {
        public void SearchFieldDisplayed(IWebDriver driver) => Assert.True(driver.FindElement(HomePageElements.SearchField).Displayed, "Search Box is Displayed.");

        public void ProductIsDisplayed(string input, IWebDriver driver) => Assert.True(driver.FindElement(HomePageElements.ProductList(input)).Text.Contains(input), $"{input} product is not displayed.");

        public void LogoDisplayed(IWebDriver driver) => Assert.True(driver.FindElement(HomePageElements.Logo).Displayed, "Amazon Logo is not displayed.");

        public void ProductRatings(IWebDriver driver) => Assert.True(driver.FindElement(HomePageElements.ProductRatingSection).Displayed, "Products Rating is Displayed.");

        public void TodaysDealProduct(IWebDriver driver) => Assert.True(driver.FindElement(HomePageElements.todaysDealSection).Displayed, "All the Products are not displayed.");

        public void CheckGiftCardtitle(IWebDriver driver) => Assert.True(driver.FindElement(HomePageElements.checkgiftCardstitle).Displayed, "Gift cards Title are not displayed.");

        public void CheckGiftCardDisplayed(IWebDriver driver) => Assert.True(driver.FindElement(HomePageElements.checkgiftCards).Displayed, "Gift cards Title are not displayed.");
       
    }
}
