using OpenQA.Selenium;
using WordpressAutomationTests.Core.Infrastructure;

namespace WordpressAutomationTests.Sections.Administration.AdminBar
{
    public class AdminBarElements : ElementsBase
    {
        public AdminBarElements(IWebDriver webDriver) 
            : base(webDriver)
        {
        }

        public IWebElement DisplayName => WebDriver.FindElement(By.CssSelector("#wp-admin-bar-my-account .display-name")); 
    }
}