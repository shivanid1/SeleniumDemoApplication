using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SeleniumDemoApplication.Pages.HomePage
{
    [Binding]
    class HomePageSteps
    {
        private IWebDriver driver;
        private HomePage _page;
        private HomePageValidation _pageValidation;

        public HomePageSteps()
        {
            driver = FeatureContext.Current.Get<IWebDriver>("driver");
            _page = new HomePage();
            _pageValidation = new HomePageValidation();
        }

        [Given(@"I go to home page")]
        public void GivenIGoToHomePage()
        {
            _page.EnterUrl(driver);
        }

        [Then(@"the amazon logo is displayed")]
        public void ThenTheAmazoneLogoIsDisplayed()
        {
            _pageValidation.LogoDisplayed(driver);
        }
        
        [Then(@"The Search Box is displayed")]
        public void ThenTheSearchBoxIsDisplayed()
        {
            _pageValidation.SearchFieldDisplayed(driver);
        }

         [Then(@"I click on search button")]
         public void ThenIClickOnSerachButton()
         {
             _page.ClickonSearchButton(driver);      
         }
        [When(@"Customer search for the Product (.*)")]
        public void WhenCustomerSearchForTheProduct(string input)
        {
            _page.EnterSearchData(input, driver);
        }

        [Then(@"The (.*) products are displayed")]
        public void ThenTheProductsAreDisplayed(string productName)
        {
            _pageValidation.ProductIsDisplayed(productName, driver);
        }

        [Then(@"The Ratings of the Products are displayed")]
        public void ThenTheRatingsOfTheProductsAreDisplayed()
        {
            _pageValidation.ProductRatings(driver);
        }

        [When(@"I click on ratings (.*)")]
        public void WhenIClickOnRatings(int ratingNumber)
        {
            _page.ClickonRatings(ratingNumber, driver);
        }

        [When(@"Customer click on Today's Deal")]
        public void WhenCustomerClickOnTodaySDeal()
        {
            _page.ClickonTodaysdeals(driver);
        }

        [Then(@"Today's Deal Product is displayed")]
        public void ThenTodaySDealProductIsDisplayed()
        {
            _pageValidation.TodaysDealProduct(driver);
        }
        [Then(@"Gift cards is displayed")]
        public void ThenGiftCardsIsDisplayed()
        {

            _pageValidation.CheckGiftCardDisplayed(driver);

        }

        [When(@"click on Gift cards")]
        public void WhenClickOnGiftCards()
        {
            _page.ClickOnGiftCards(driver);
        }

        [Then(@"Gift Cards Items are displayed")]
        public void ThenGiftCardsItemsAreDisplayed()
        {
            _pageValidation.CheckGiftCardtitle(driver);
        }


    }
}
