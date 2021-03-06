﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.PhantomJS;
using System;
using SeleniumGoogleSearch.settings;

namespace SeleniumGoogleSearch
{
    static class Browser
    {
        private static IWebDriver _webDriver;

        #region public
        public static void Start()
        {
            _webDriver = StartWebDriver();
        }


        public static void Navigate(string url)
        {
            _webDriver.Navigate().GoToUrl(url);
        }


        public static void Quit()
        {
            _webDriver.Quit();
            _webDriver = null;
        }

        public static ISearchContext Driver
        {
            get { return _webDriver; }
        }

        public static IWebDriver GetDriver
        {
            get { return _webDriver; }
        }
        
        #endregion
        #region private
        private static IWebDriver StartWebDriver()
        {
            switch (XmlSettingsProperties.Browser)
            {
                case "chrome":
                    _webDriver = new ChromeDriver();
                    break;
                case "phantom":
                    _webDriver = new PhantomJSDriver();
                    break;
                case "chrome_headless":
                    ChromeOptions options = new ChromeOptions();
                    options.AddArgument("--headless");
                    _webDriver = new ChromeDriver(options);
                    break;
                default:
                    _webDriver = new ChromeDriver();
                    break;
            }
            _webDriver.Manage().Window.Maximize();
            Helper.Logger.LogInfo("Selected browser - " + XmlSettingsProperties.Browser);
            // _webDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(50)); old implicitly wait
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            return _webDriver;
        }
        #endregion
    }
}
