using WordpressAutomationTests.Core.Infrastructure;
using WordpressAutomationTests.Pages.Administration.LogIn;
using Xunit;

namespace WordpressAutomationTests.Tests.Administration
{
    public class AdministrationLogInTests : WebsiteTestBase
    {
        private LogInPage _logInPage;

        public AdministrationLogInTests()
        {
            _logInPage = new LogInPage(WebDriver);
        }

        [Fact]
        public void LogIn_ShouldShowEmptyFieldsValidationErrors_WhenSomeDataIsMissing()
        {
            _logInPage
                .Open(Configuration.WebsiteUrl)
                .LogIn(string.Empty, string.Empty)
                .Assert()
                .HasValidationError("The username field is empty")
                .HasValidationError("The password field is empty");
        }

        [Fact]
        public void LogIn_ShouldShowUnknownUserValidationError_WhenUserIsUnknown()
        {
            _logInPage
                .Open(Configuration.WebsiteUrl)
                .LogIn("not_existing_account_name", "invalid_password")
                .Assert()
                .HasValidationError("Unknown username");
        }

        [Fact]
        public void LogIn_ShouldShowInvalidPasswordValidationError_WhenUserPasswordIsWrong()
        {
            _logInPage
                .Open(Configuration.WebsiteUrl)
                .LogIn(Configuration.TestUser.Username, "invalid_password")
                .Assert()
                .HasValidationError("The password you entered for the username admin is incorrect");
        }

        [Fact]
        public void LogIn_ShouldLogInSuccessfully_WhenCredentialsAreCorrect()
        {
            var dashboard = _logInPage
                .Open(Configuration.WebsiteUrl)
                .LogIn(Configuration.TestUser.Username, Configuration.TestUser.Password)
                .DashboardPage();

            dashboard.AdminBar
                .Assert()
                .HasDisplayName(Configuration.TestUser.Username);

            dashboard
                .Assert()
                .HasHeader();
        }
    }
}