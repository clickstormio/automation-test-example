using OpenQA.Selenium;

namespace WordpressAutomationTests.Core.Infrastructure
{
    public abstract class SectionBase<TElements, TAsserts>
        where TElements : ElementsBase
        where TAsserts : AssertsBase<TElements>
    {
        protected SectionBase(IWebDriver webDriver, TElements elements, TAsserts asserts)
        {
            WebDriver = webDriver;
            Elements = elements;
            Asserts = asserts;
        }

        protected IWebDriver WebDriver { get; }
        protected TElements Elements { get; }
        protected TAsserts Asserts { get; }

        public TAsserts Assert() => Asserts;
    }
}