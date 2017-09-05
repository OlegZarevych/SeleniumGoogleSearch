using NUnit.Framework;
using SeleniumGoogleSearch.settings;

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
        }

        [TearDown]
        public void PostCondition()
        {
            Browser.Quit();
        }
        #endregion
    }
}
