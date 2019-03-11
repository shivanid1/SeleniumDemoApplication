using OpenQA.Selenium;
using SeleniumDemoApplication.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SeleniumDemoApplication.Hooks
{
    [Binding]
    public class WebDriverHooks
    {
        static WebDriverSetup webDriverSetUp;

        [BeforeTestRun]
        public static void InitializeWebDriverSetUp()
        {
            webDriverSetUp = new WebDriverSetup();
        }

        [BeforeFeature("browser_setup_before_feature")]
        public static void LaunchDriver()
        {
            FeatureContext.Current.Add("driver", webDriverSetUp.GetWebDriver());
        }

        [AfterFeature("close_current_browser")]
        public static void TearDown()
        {
            webDriverSetUp.CloseWebDriver(FeatureContext.Current.Get<IWebDriver>("driver"));

        }
    }
}
