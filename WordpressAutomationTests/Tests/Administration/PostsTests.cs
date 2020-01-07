using WordpressAutomationTests.Core.Infrastructure;
using WordpressAutomationTests.Pages.Administration.LogIn;
using Xunit;

namespace WordpressAutomationTests.Tests.Administration
{
    public class PostsTests : WebsiteTestBase
    {
        private LogInPage _logInPage;

        public PostsTests()
        {
            _logInPage = new LogInPage(WebDriver);
        }

        [Fact]
        public void PublishPost_ShouldPublishButtonBeDisabled_WhenPostTitleIsEmpty()
        {
            var newPostPage = _logInPage
                .Open(Configuration.WebsiteUrl)
                .LogIn(Configuration.TestUser.Username, Configuration.TestUser.Password)
                .DashboardPage()
                .AdminMenu.OpenPostsPage()
                .AddNewPost();

            newPostPage
                .Assert()
                .PublishIsDisabled();
        }

        [Fact]
        public void PublishPost_ShouldPublishNewPost_WhenAllNewPostRequiredFieldsHaveValues()
        {
            var postsPage = _logInPage
                .Open(Configuration.WebsiteUrl)
                .LogIn(Configuration.TestUser.Username, Configuration.TestUser.Password)
                .DashboardPage()
                .AdminMenu.OpenPostsPage()
                .AddNewPost()
                .SetTitle("test-post-title")
                .Publish()
                .ConfirmPublish()
                .AdminMenu.OpenPostsPage();

            postsPage
                .Assert()
                .HasPostOnList("test-post-title");

            //todo cleanup
        }
    }
}
