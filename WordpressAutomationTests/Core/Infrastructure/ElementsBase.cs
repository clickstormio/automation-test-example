using OpenQA.Selenium;

namespace WordpressAutomationTests.Core.Infrastructure
{
    public abstract class ElementsBase
    {
        public ElementsBase(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        protected IWebDriver WebDriver { get; }
    }
}