using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WordpressAutomationTests.Core.Extensions
{
    public class WebDriverFactory
    {
        public static IWebDriver Create()
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            return driver;
        }
    }
}