using FluentAssertions;
using OpenQA.Selenium;
using WordpressAutomationTests.Core.Infrastructure;

namespace WordpressAutomationTests.Pages.Administration.Posts
{
    public class PostsPageAsserts : AssertsBase<PostsPageElements>
    {
        public PostsPageAsserts(IWebDriver webDriver, PostsPageElements elements) 
            : base(webDriver, elements)
        {
        }

        public PostsPageAsserts HasPostOnList(string title)
        {
            WebDriver.FindElements(By.ClassName("row-title")).Should().Contain(x => x.Text == title);
            return this;
        }
    }
}
