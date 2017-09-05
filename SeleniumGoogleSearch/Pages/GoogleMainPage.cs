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
        private IWebElement SearchField { get; set; }

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = _searchButton)]
        private IWebElement SearchButton { get; set; }
        #endregion

        #region public
        public GoogleSearchResultPage SearchText(string text)
        {
            SearchField.SendKeys(text);
            SearchButton.Submit();
            return new GoogleSearchResultPage();

        }

        #endregion
    }
}
