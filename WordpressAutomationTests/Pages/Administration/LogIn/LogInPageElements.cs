using OpenQA.Selenium;
using WordpressAutomationTests.Core.Infrastructure;

namespace WordpressAutomationTests.Pages.Administration.LogIn
{
    public class LogInPageElements : ElementsBase
    {
        public LogInPageElements(IWebDriver webDriver) 
            : base(webDriver)
        {
        }

        public IWebElement Username => WebDriver.FindElement(By.Id("user_login"));
        public IWebElement Password => WebDriver.FindElement(By.Id("user_pass"));
        public IWebElement LogIn => WebDriver.FindElement(By.Id("wp-submit"));
        public IWebElement ValidationErrors => WebDriver.FindElement(By.Id("login_error"));
    }
}