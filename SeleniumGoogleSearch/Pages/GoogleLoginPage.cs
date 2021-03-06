﻿using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using SeleniumGoogleSearch.Core;

namespace SeleniumGoogleSearch.Pages
{
    public class GoogleLoginPage
    {
        #region locators
        private const string _emailInput = "//*[@id='identifierId']";
        private const string _nextButton = "//*[@id='identifierNext']";
        private const string _moreButton = "//*[@id='view_container']//div[@class='IMH1vc lUHSR Hj2jlf']";
        private const string _signUpLabel = "//content[@class='z80M1']";
        private const string _signUpButton = ".//*[@id='SIGNUP']/div";
        #endregion

        #region PO
        [CacheLookup]
        [FindsBy(How = How.XPath, Using = _emailInput)]
        private IWebElement EmailInput { get; set; }

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = _nextButton)]
        private IWebElement NextButton { get; set; }

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = _moreButton)]
        private IWebElement MoreButton { get; set; }

        [CacheLookup]
        [FindsBy(How = How.XPath, Using =_signUpLabel)]
        private IWebElement SignUpLabel { get; set; }

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = _signUpButton)]
        private IWebElement SignUpButton { get; set; }
        #endregion

        #region public
        public void EnterEmail(string email)
        {
            EmailInput.EnterText(email);
        }

        public void LogIn (string email)
        {
            EmailInput.EnterText(email);
            NextButton.Click();
            ///TODO
        }

        public GoogleRegisterPage SignUp()
        {
            SignUpLabel.ClickFromJs();
            return Page.Register;
        }

        public GoogleRegisterPage MoreAndSignUp()
        {
            MoreButton.Click();
            SignUpLabel.Hover();
            SignUpButton.Click();

            return Page.Register;
        }
        #endregion
    }
}