using Microsoft.Extensions.Configuration;

namespace WordpressAutomationTests.Core.Configuration
{
    public class TestConfiguration
    {
        private readonly IConfiguration _configuration;

        public TestConfiguration(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string WebsiteUrl => _configuration["WebsiteUrl"];
        public (string Username, string Password) TestUser => (_configuration["TestUser:Username"], _configuration["TestUser:Password"]);
    }
}