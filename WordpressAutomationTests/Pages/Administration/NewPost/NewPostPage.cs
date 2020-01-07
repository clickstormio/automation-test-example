using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using WordpressAutomationTests.Pages.Administration.Shared;

namespace WordpressAutomationTests.Pages.Administration.NewPost
{
    public class NewPostPage : AdminPageBase<NewPostElements, NewPostAsserts>
    {
        public NewPostPage(IWebDriver webDriver) 
            : base(webDriver, new NewPostElements(webDriver), new NewPostAsserts(webDriver, new NewPostElements(webDriver)))
        {
        }

        public NewPostPage SetTitle(string title)
        {
            Elements.Title.SendKeys(title);
            return this;
        }

        public NewPostPage Publish()
        {
            Elements.Publish.Click();
            return this;
        }

        public NewPostPage ConfirmPublish()
        {
            Elements.ConfirmPublish.Click();

            var wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(10));
            wait.Until(webDriver => webDriver.FindElement(By.ClassName("post-publish-panel__postpublish-post-address")));

            return this;
        }
    }
}
