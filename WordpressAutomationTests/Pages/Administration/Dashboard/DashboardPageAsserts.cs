using FluentAssertions;
using OpenQA.Selenium;
using WordpressAutomationTests.Core.Infrastructure;

namespace WordpressAutomationTests.Pages.Administration.Dashboard
{
    public class DashboardPageAsserts : AssertsBase<DashboardPageElements>
    {
        public DashboardPageAsserts(IWebDriver webDriver, DashboardPageElements elements) 
            : base(webDriver, elements)
        {
        }

        public DashboardPageAsserts HasHeader()
        {
            Elements.Header.Text.Should().Be("Dashboard");
            return this;
        }
    }
}
