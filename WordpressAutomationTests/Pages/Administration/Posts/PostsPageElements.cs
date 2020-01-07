using OpenQA.Selenium;
using WordpressAutomationTests.Core.Infrastructure;

namespace WordpressAutomationTests.Pages.Administration.Posts
{
    public class PostsPageElements : ElementsBase
    {
        public PostsPageElements(IWebDriver webDriver) 
            : base(webDriver)
        {
        }

        public IWebElement AddNew => WebDriver.FindElement(By.ClassName("page-title-action"));
    }
}
