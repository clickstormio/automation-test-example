using OpenQA.Selenium;
using WordpressAutomationTests.Core.Extensions;
using WordpressAutomationTests.Infrastructure;
using WordpressAutomationTests.Pages.Administration.Dashboard;

namespace WordpressAutomationTests.Pages.Administration.LogIn
{
    public class LogInPage : PageBase<LogInPageElements, LogInPageAsserts>
    {
        public LogInPage(IWebDriver webDriver) 
            : base(webDriver, new LogInPageElements(webDriver), new LogInPageAsserts(webDriver, new LogInPageElements(webDriver)))
        {
        }

        public LogInPage Open(string baseUrl)
        {
            WebDriver.Navigate().GoToUrl($"{baseUrl}/wp-admin");
            return this;
        }

        public LogInPage LogIn(string username, string password)
        {
            Elements.Username.ClearAndSendKeys(username);
            Elements.Password.ClearAndSendKeys(password);

            Elements.LogIn.Click();
            return this;
        }

        public DashboardPage DashboardPage()
        {
            return new DashboardPage(WebDriver);
        }
    }
}