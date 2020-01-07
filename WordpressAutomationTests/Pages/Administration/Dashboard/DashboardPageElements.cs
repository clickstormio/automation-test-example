using OpenQA.Selenium;
using WordpressAutomationTests.Core.Infrastructure;

namespace WordpressAutomationTests.Pages.Administration.Dashboard
{
    public class DashboardPageElements : ElementsBase
    {
        public DashboardPageElements(IWebDriver webDriver) 
            : base(webDriver)
        {
        }

        public IWebElement Header => WebDriver.FindElement(By.CssSelector("#wpbody-content .wrap h1"));
    }
}