using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace SeleniumGoogleSearch.Pages
{
    class GoogleMainPage
    {
        #region locators
        private const string _searchField = "//input[@id='lst-ib']";
        private const string _searchButton = "//input[@name='btnK']";
        #endregion

        #region Constructor \ PageFactory
        public GoogleMainPage()
        {
            PageFactory.InitElements(Browser.Driver, this);
        }
        #endregion

        #region PO
        [CacheLookup]
        [FindsBy(How = How.XPath, Using = _searchField)]
        private IWebElement SearchField { get; }

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = _searchButton)]
        private IWebElement SearchButton { get; }
        #endregion

        #region public
        public GoogleSearchResultPage SearchText(string text)
        {
            SearchField.SendKeys(text);
            return new GoogleSearchResultPage();

        }

        #endregion
    }
}
