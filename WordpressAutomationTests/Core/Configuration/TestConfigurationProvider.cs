using Microsoft.Extensions.Configuration;
using System.IO;

namespace WordpressAutomationTests.Core.Configuration
{
    public static class TestConfigurationProvider
    {
        public static TestConfiguration Get()
        {
            var configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("test-configuration.json")
                .Build();

            return new TestConfiguration(configurationBuilder);
        }
    }
}