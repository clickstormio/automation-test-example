using OpenQA.Selenium;
using WordpressAutomationTests.Core.Infrastructure;

namespace WordpressAutomationTests.Sections.Administration.AdminMenu
{
    public class AdminMenuElements : ElementsBase
    {
        public AdminMenuElements(IWebDriver webDriver) 
            : base(webDriver)
        {
        }

        public IWebElement Posts => WebDriver.FindElement(By.Id("menu-posts"));
    }
}
