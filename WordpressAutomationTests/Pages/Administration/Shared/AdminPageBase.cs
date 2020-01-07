using OpenQA.Selenium;
using WordpressAutomationTests.Core.Infrastructure;
using WordpressAutomationTests.Sections.Administration.AdminBar;
using WordpressAutomationTests.Sections.Administration.AdminMenu;

namespace WordpressAutomationTests.Pages.Administration.Shared
{
    public abstract class AdminPageBase<TElements, TAsserts> : SectionBase<TElements, TAsserts>
        where TElements : ElementsBase
        where TAsserts : AssertsBase<TElements>
    {
        protected AdminPageBase(IWebDriver webDriver, TElements elements, TAsserts asserts) 
            : base(webDriver, elements, asserts)
        {
            AdminBar = new AdminBarSection(webDriver);
            AdminMenu = new AdminMenuSection(webDriver);
        }

        public AdminBarSection AdminBar { get; }
        public AdminMenuSection AdminMenu { get; }
    }
}
