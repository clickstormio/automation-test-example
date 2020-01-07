using OpenQA.Selenium;
using WordpressAutomationTests.Core.Infrastructure;

namespace WordpressAutomationTests.Pages.Administration.NewPost
{
    public class NewPostElements : ElementsBase
    {
        public NewPostElements(IWebDriver webDriver) 
            : base(webDriver)
        {
        }

        public IWebElement Publish => WebDriver.FindElement(By.ClassName("editor-post-publish-panel__toggle"));
        public IWebElement ConfirmPublish => WebDriver.FindElement(By.ClassName("editor-post-publish-button"));
        public IWebElement Title => WebDriver.FindElement(By.Id("post-title-0"));
    }
}
