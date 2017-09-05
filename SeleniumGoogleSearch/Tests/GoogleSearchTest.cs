using NUnit.Framework;
using SeleniumGoogleSearch.Core;
using SeleniumGoogleSearch.Pages;
using SeleniumGoogleSearch.settings;

namespace SeleniumGoogleSearch.Tests
{
    [TestFixture]
    public class GoogleSearchTest : TestBase
    {


        #region Tests

        /// <summary>
        /// This text search from text in Google and check if in result is Wikipedia 
        /// </summary>
        [Test]
        public void SearchText()
        {
            GoogleMainPage mp = new GoogleMainPage();
            var resultPage = mp.SearchText("QA");
            resultPage.ResultLinkByText("QA");

        }

        #endregion
    }
}
