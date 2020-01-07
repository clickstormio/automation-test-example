using OpenQA.Selenium;

namespace WordpressAutomationTests.Core.Extensions
{
    public static class WebDriverExtensions
    {
        public static void ClearAndSendKeys(this IWebElement webElement, string text)
        {
            webElement.Clear();
            webElement.SendKeys(text);
        }
    }
}