using OpenQA.Selenium;
using System;
using WordpressAutomationTests.Core.Configuration;
using WordpressAutomationTests.Core.Extensions;

namespace WordpressAutomationTests.Core.Infrastructure
{
    public abstract class WebsiteTestBase : IDisposable
    {
        public WebsiteTestBase()
        {
            WebDriver = WebDriverFactory.Create();
            Configuration = TestConfigurationProvider.Get();
        }

        protected IWebDriver WebDriver { get; }
        protected TestConfiguration Configuration { get; }

        public void Dispose()
        {
            WebDriver?.Dispose();
        }
    }
}