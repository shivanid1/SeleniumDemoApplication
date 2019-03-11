using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumDemoApplication.Events;
using SeleniumDemoApplication.Page_Elements;
using TechTalk.SpecFlow;

namespace SeleniumDemoApplication.Pages.HomePage
{
    public class HomePage
    {

        public void EnterSearchData(string input, IWebDriver driver) => driver.FindElement(HomePageElements.SearchField).SendKeys(input);

        public void ClickonSearchButton(IWebDriver driver) => driver.FindElement(HomePageElements.ClickonSearchBtn).Click();

        public void EnterUrl(IWebDriver driver) => driver.Navigate().GoToUrl(HomePageElements.Url);

        public void ClickonRatings(int productRating, IWebDriver driver) => driver.FindElement(HomePageElements.ClickProductRating(productRating)).Click();

        public void ClickonTodaysdeals(IWebDriver driver) => driver.FindElement(HomePageElements.ClickTodaysDeal).Click();

        public void ClickOnGiftCards(IWebDriver driver) => driver.JavaScriptClickElement(driver.FindElement(HomePageElements.clickgiftCards));

    }
}
