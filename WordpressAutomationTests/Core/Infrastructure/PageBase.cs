using OpenQA.Selenium;
using WordpressAutomationTests.Core.Infrastructure;

namespace WordpressAutomationTests.Infrastructure
{
    public abstract class PageBase<TElements, TAsserts> : SectionBase<TElements, TAsserts>
        where TElements : ElementsBase
        where TAsserts : AssertsBase<TElements>
    {
        protected PageBase(IWebDriver webDriver, TElements elements, TAsserts asserts) 
            : base(webDriver, elements, asserts)
        {
        }
    }
}