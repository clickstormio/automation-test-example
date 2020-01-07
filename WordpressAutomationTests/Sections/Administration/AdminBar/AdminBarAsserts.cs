using FluentAssertions;
using OpenQA.Selenium;
using WordpressAutomationTests.Core.Infrastructure;

namespace WordpressAutomationTests.Sections.Administration.AdminBar
{
    public class AdminBarAsserts : AssertsBase<AdminBarElements>
    {
        public AdminBarAsserts(IWebDriver webDriver, AdminBarElements elements) 
            : base(webDriver, elements)
        {
        }

        public AdminBarAsserts HasDisplayName(string expectedDisplayName)
        {
            Elements.DisplayName.Text.Should().Be(expectedDisplayName);
            return this;
        }
    }
}
