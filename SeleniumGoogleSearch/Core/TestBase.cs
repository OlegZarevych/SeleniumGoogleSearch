using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using SeleniumGoogleSearch.settings;
using System;
using System.IO;
using System.Reflection;

namespace SeleniumGoogleSearch.Core
{
    public class TestBase
    {
        #region setup
        [SetUp]
        public void Setup()
        {
            Browser.Start();
            Browser.Navigate(XmlSettingsProperties.Url);
            Helper.Logger.LogInfo("Browser started");
        }

        [TearDown]
        public void PostCondition()
        {
            Browser.Quit();
            Helper.Logger.LogInfo("Browser closed");
        }

        [TearDown]
        public void TakeScreenShotAfterFail()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                Helper.Logger.LogError("TEST FAIL");
                DateTime time = DateTime.Now;
                string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                string dateToday = "_date_" + time.ToString("yyyy-MM-dd") + "_time_" + time.ToString("HH-mm-ss");
                var screenshot = ((ITakesScreenshot)Browser.GetDriver).GetScreenshot();
                screenshot.SaveAsFile(filePath + "Exception" + dateToday + ".png", ScreenshotImageFormat.Png);
                Helper.Logger.LogError("Screenshot location " + filePath + "Exception" + dateToday + ".png");
            }
        }
        #endregion
    }
}
