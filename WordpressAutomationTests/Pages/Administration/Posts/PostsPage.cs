using OpenQA.Selenium;
using WordpressAutomationTests.Pages.Administration.NewPost;
using WordpressAutomationTests.Pages.Administration.Shared;

namespace WordpressAutomationTests.Pages.Administration.Posts
{
    public class PostsPage : AdminPageBase<PostsPageElements, PostsPageAsserts>
    {
        public PostsPage(IWebDriver webDriver) 
            : base(webDriver, new PostsPageElements(webDriver), new PostsPageAsserts(webDriver, new PostsPageElements(webDriver)))
        {
        }

        public NewPostPage AddNewPost()
        {
            Elements.AddNew.Click();
            return new NewPostPage(WebDriver);
        }
    }
}
