using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemoApplication.Events
{
    
        public static class ClickEvents
        {
            public static void JavaScriptClickElement(this IWebDriver driver, IWebElement element) => ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", element);
        }

}
