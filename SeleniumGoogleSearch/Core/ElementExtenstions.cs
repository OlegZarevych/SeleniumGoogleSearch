using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SeleniumGoogleSearch.Core
{
    public static class ElementExtenstions
    {
        public static void EnterText(this IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }

        public static bool IsDisplayed(this IWebElement element)
        {
            bool result;
            try
            {
                result = element.Displayed;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public static void SelectByText(this IWebElement element, string text)
        {
            SelectElement oSelect = new SelectElement(element);
            oSelect.SelectByText(text);
        }

        public static void ClickFromJs(this IWebElement element)
        {
            ((IJavaScriptExecutor)Browser.Driver).ExecuteScript("arguments[0].click();", element);
        }

        public static void DoubleClick(this IWebElement element)
        {
            new Actions(Browser.GetDriver).DoubleClick(element).Perform();
        }

        public static void Hover(this IWebElement element)
        {
            new Actions(Browser.GetDriver).MoveToElement(element).Perform();
        }

        public static void HoverAndClick(this IWebElement element)
        {
            new Actions(Browser.GetDriver).MoveToElement(element).Perform();
            element.Click();
        }

        public static void WaitForAjax(this IWebDriver driver, int timeoutSecs = 10, bool throwException = false)
        {
            for (var i = 0; i < timeoutSecs; i++)
            {
                var ajaxIsComplete = (bool)(driver as IJavaScriptExecutor).ExecuteScript("return jQuery.active == 0");
                if (ajaxIsComplete) return;
                Thread.Sleep(1000);
            }
            if (throwException)
            {
                throw new Exception("WebDriver timed out waiting for AJAX call to complete");
            }
        }
    }
}
