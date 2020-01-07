using FluentAssertions;
using OpenQA.Selenium;
using WordpressAutomationTests.Core.Infrastructure;

namespace WordpressAutomationTests.Pages.Administration.LogIn
{
    public class LogInPageAsserts : AssertsBase<LogInPageElements>
    {
        public LogInPageAsserts(IWebDriver webDriver, LogInPageElements elements) 
            : base(webDriver, elements)
        {
        }

        public LogInPageAsserts HasValidationError(string expectedError)
        {
            Elements.ValidationErrors.Text.Should().Contain(expectedError);
            return this;
        }
    }
}