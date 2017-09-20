using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace SeleniumGoogleSearch.Pages
{
    public class GoogleSearchResultPage
    {
        #region locators
        private const string _resultList = "//div[@class='g']";
        private const string _linkByText = "//a[text()='{0}']";

        #endregion


       

        #region PO
        [FindsBy(How = How.XPath, Using = _linkByText)]
        private IWebElement LinkByText { get; set; }

        [FindsBy(How = How.XPath, Using = _resultList)]
        public IList<IWebElement> ResultList { get; set; }
        #endregion

        #region public

        public void ResultLinkByText(string text)
        {
            
        }


        #endregion
    }
}
