using FluentAssertions;
using OpenQA.Selenium;
using WordpressAutomationTests.Core.Infrastructure;

namespace WordpressAutomationTests.Pages.Administration.NewPost
{
    public class NewPostAsserts : AssertsBase<NewPostElements>
    {
        public NewPostAsserts(IWebDriver webDriver, NewPostElements elements) 
            : base(webDriver, elements)
        {
        }

        public NewPostAsserts PublishIsDisabled()
        {
            Elements.Publish.GetAttribute("aria-disabled").Should().Be("true");
            return this;
        }
    }
}
