using OpenQA.Selenium;
using SeleniumDemoApplication.Pages.TodaysDeals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SeleniumDemoApplication.Pages.TodaysDeals
{
    [Binding]
    class TodaysDealsSteps
    {
        private IWebDriver driver;
        private TodaysDeals _page;
        private TodaysDealsValidation _pageValidation;

        public TodaysDealsSteps()
        {
            driver = FeatureContext.Current.Get<IWebDriver>("driver");
            _page = new TodaysDeals();
            _pageValidation = new TodaysDealsValidation();
        }

        [Then(@"Today's Deal Product are displayed")]
        public void ThenTodaySDealProductAreDisplayed()
        {
            _pageValidation.todaysDealProductDisplayed(driver);
        }
        
        [When(@"select the price link")]
        public void WhenSelectThePriceLink()
        {
            _page.SelectProductPrice(driver);
        }

        [Then(@"The Product of that price displayed")]
        public void ThenTheProductOfThatPriceDisplayed()
        {
            _pageValidation.checkProductPrice(driver);
        }

        [Then(@"The Sort by Link is displayed")]
        public void ThenTheSortByLinkIsDisplayed()
        {
            _pageValidation.checkSortByLink(driver);
        }

        [When(@"Click on Dropdown List")]
        public void WhenClickOnDropdownList()
        {
            _page.ClickOnDropDown(driver);
        }

        [Then(@"The Price options are dispalyed")]
        public void ThenThePriceOptionsAreDispalyed()
        {
            _pageValidation.checkPriceOptions(driver);
        }

        [When(@"Click on the options Low to high")]
        public void WhenClickOnTheOptionsLowToHigh()
        {
            _page.ClickOnLowtohighPrice(driver);
        }

        [Then(@"Low to High Price Products displayed")]
        public void ThenLowToHighPriceProductsDisplayed()
        {
            _pageValidation.checkLowestPriceProdust(driver);
        }

        [When(@"Click on Orders")]
        public void WhenClickOnOrders()
        {
            _page.ClickOnOrders(driver);
        }

        [Then(@"Orders that have been given are displayed")]
        public void ThenOrdersThatHaveBeenGivenAreDisplayed()
        {
            _pageValidation.checktheOrders(driver);
        }
        [Then(@"Header is displayed")]
        public void ThenHeaderIsDisplayed()
        {
            _pageValidation.checkHeader(driver);
        }

        [Then(@"Footer is displayed")]
        public void ThenFooterIsDisplayed()
        {
            _pageValidation.checkFooter(driver);
        }

    }
}
