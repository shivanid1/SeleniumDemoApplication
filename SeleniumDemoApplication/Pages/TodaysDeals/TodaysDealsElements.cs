using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumDemoApplication.Pages.ProductPrice
{
    class todaysDealsElements
    {
        public static By priceField = By.XPath("//div[@class='a-row a-spacing-micro']//span[contains(text(),'Price')]");

        public static By checkProductPrice = By.XPath("(//div[@class='a-row dealDetailContainer']//div[@class='a-row priceBlock unitLineHeight']//span)[1]");

        public static By ClickonPriceLessthen25 = By.XPath("//*[@class='a-row a-spacing-small filterItem']//span[contains(text(),'Price')]/../..//a[contains(text(),'Under $25')]");

        public static By clickOnLowtoHigh = By.XPath("//div[@class='a-popover-wrapper']//div[@class='a-popover-inner']//*[contains(text(),' Price - Low to High')]");

        public static By sortByPrice = By.XPath("//div[@id='FilterItemView_sortOrder_dropdown']//span[@class='a-size-base']");

        public static By clickOnDropDown = By.XPath("//span[@class='a-button-inner']//span[@class='a-button-text a-declarative']");

        public static By lowtohighPrice = By.XPath("//div[@class='a-popover-wrapper']//div[@class='a-popover-inner']//*[contains(text(),' Price - Low to High')]");

        public static By lowestPriceProdust = By.XPath("(//div[@class='a-row dealDetailContainer']//div[@class='a-row priceBlock unitLineHeight']//span)[1]");

        public static By clickOnOrders = By.XPath("//div[@id='nav-tools']//span[contains(text(),'Orders')]");

        public static By checkOrders = By.XPath("//div[@class='a-section a-spacing-none auth-navbar']//a[@class='a-link-nav-icon']");

        public static By checkFooter = By.XPath("//div[@id='navFooter']");

        public static By checkHeader = By.XPath("//div[@id='nav-main']");
    }
}
