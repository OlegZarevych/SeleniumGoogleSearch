using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using SeleniumGoogleSearch.Core;

namespace SeleniumGoogleSearch.Pages
{
    public class GoogleMainPage
    {
        #region locators
        private const string _searchField = "//input[@id='lst-ib']";
        private const string _searchButton = "//input[@name='btnK']";
        private const string _logInButton = "//*[@id='gb_70']";
        private const string _helpPopup = "//div[@id='sbse0']/div[@class='sbqs_c']";
        #endregion

        #region Constructor \ PageFactory
        public GoogleMainPage()
        {
 //           PageFactory.InitElements(Browser.Driver, this);
        }
        #endregion

        #region PO
        [CacheLookup]
        [FindsBy(How = How.XPath, Using = _searchField)]
        private IWebElement SearchField { get; set; }

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = _searchButton)]
        private IWebElement SearchButton { get; set; }

        [CacheLookup]
        [FindsBy(How = How.XPath, Using =_logInButton)]
        private IWebElement LoginButton { get; set; }

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = _helpPopup)]
        private IWebElement HelpPopup { get; set; }
        #endregion

        #region public
        public GoogleSearchResultPage SearchText(string text)
        {
            SearchField.SendKeys(text);
            SearchButton.Submit();
            return Page.GoogleSearchResult;
        }

        public GoogleLoginPage OpenLoginPage()
        {
            LoginButton.Click();
            return Page.Login;
        }

        public void EnterTextInSearchField(string text)
        {
            SearchField.SendKeys(text);
        }

        public string SearchResultTextInHelpPopup()
        {
            //wait for 1 second
            HelpPopup.WaitForElementIsDisplayed(1);
            return HelpPopup.Text;
        }
        
        #endregion
    }
}
