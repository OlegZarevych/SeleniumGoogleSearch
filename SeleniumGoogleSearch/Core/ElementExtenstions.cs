using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
