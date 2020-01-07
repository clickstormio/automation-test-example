using OpenQA.Selenium;

namespace WordpressAutomationTests.Core.Infrastructure
{
    public abstract class AssertsBase<TElements>
        where TElements : ElementsBase
    {
        public AssertsBase(IWebDriver webDriver, TElements elements)
        {
            WebDriver = webDriver;
            Elements = elements;
        }

        protected IWebDriver WebDriver { get; }
        protected TElements Elements { get; }
    }
}