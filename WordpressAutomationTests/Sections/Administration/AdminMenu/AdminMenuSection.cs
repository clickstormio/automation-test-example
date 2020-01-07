using OpenQA.Selenium;
using WordpressAutomationTests.Core.Infrastructure;
using WordpressAutomationTests.Pages.Administration.Posts;

namespace WordpressAutomationTests.Sections.Administration.AdminMenu
{
    public class AdminMenuSection : SectionBase<AdminMenuElements, EmptyAsserts<AdminMenuElements>>
    {
        public AdminMenuSection(IWebDriver webDriver) 
            : base(webDriver, new AdminMenuElements(webDriver), new EmptyAsserts<AdminMenuElements>())
        {
        }

        public PostsPage OpenPostsPage()
        {
            Elements.Posts.Click();
            return new PostsPage(WebDriver);
        }
    }
}
