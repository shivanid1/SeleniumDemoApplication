using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumDemoApplication.Page_Elements
{
    public static class HomePageElements

    {
        public static string Url= "https://www.amazon.com/";

        public static By SearchField = By.Id("twotabsearchtextbox");

        public static By ProductList(string productName) => By.XPath($"(//div[@class='sg-col-inner']//span[contains(text(),'by {productName}')]/../..//span[@class='a-size-medium a-color-base a-text-normal'])[2]");

        public static By Logo = By.XPath("//div[@id='nav-logo']/a");

        public static By ClickonSearchBtn = By.XPath("//div[@class='nav-right']//input[@class='nav-input']");

        public static By ProductRatingSection = By.Id("reviewsRefinements");

        public static By ClickTodaysDeal = By.XPath("(//div[@id='nav-xshop'] //a[@class='nav-a'])[2]");

        public static By ClickProductRating(int ratingNumber) => By.XPath($"//div[@id='reviewsRefinements']//span[@class='a-icon-alt' and contains(text(),'{ratingNumber}')]");

        public static By ValidateRatings(string ratingStars) => By.XPath($"//span[@class='a-icon-alt' and contains(text(),'{ratingStars}')]");

        public static By todaysDealSection = By.XPath("//div[@id='widgetContent']//span[contains(text(),'DEAL OF THE DAY')]");

        public static By checkgiftCards = By.XPath("//div[@id='nav-xshop']//a[@class='nav-a'][3]");

        public static By clickgiftCards = By.XPath("//div[@id='nav-xshop']//a[@class='nav-a'][3]");

        public static By checkgiftCardstitle = By.XPath("//img[contains(@src,'https://images-na.ssl-images-amazon.com/images/G/01/gift-certificates/consumer/2018/GCLP/2x/dt_header_giftcards_2x._CB483877305_.jpg0376_.jpg')]");
    }
}
