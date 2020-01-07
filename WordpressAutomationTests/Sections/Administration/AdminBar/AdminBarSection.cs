using OpenQA.Selenium;
using WordpressAutomationTests.Core.Infrastructure;

namespace WordpressAutomationTests.Sections.Administration.AdminBar
{
    public class AdminBarSection : SectionBase<AdminBarElements, AdminBarAsserts>
    {
        public AdminBarSection(IWebDriver webDriver) 
            : base(webDriver, new AdminBarElements(webDriver), new AdminBarAsserts(webDriver, new AdminBarElements(webDriver)))
        {
        }
    }
}