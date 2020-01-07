using OpenQA.Selenium;
using WordpressAutomationTests.Infrastructure;
using WordpressAutomationTests.Sections.Administration.AdminBar;

namespace WordpressAutomationTests.Pages.Administration.Dashboard
{
    public class DashboardPage : PageBase<DashboardPageElements, DashboardPageAsserts>
    {
        public DashboardPage(IWebDriver webDriver)
            : base(webDriver, new DashboardPageElements(webDriver), new DashboardPageAsserts(webDriver, new DashboardPageElements(webDriver)))
        {
            AdminBar = new AdminBarSection(webDriver);
        }

        public AdminBarSection AdminBar { get; }
    }
}