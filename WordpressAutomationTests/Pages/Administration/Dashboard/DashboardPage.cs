using OpenQA.Selenium;
using WordpressAutomationTests.Pages.Administration.Shared;

namespace WordpressAutomationTests.Pages.Administration.Dashboard
{
    public class DashboardPage : AdminPageBase<DashboardPageElements, DashboardPageAsserts>
    {
        public DashboardPage(IWebDriver webDriver)
            : base(webDriver, new DashboardPageElements(webDriver), new DashboardPageAsserts(webDriver, new DashboardPageElements(webDriver)))
        {
        }
    }
}