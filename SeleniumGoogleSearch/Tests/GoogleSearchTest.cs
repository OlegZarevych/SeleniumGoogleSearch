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
        [TestCase("QA")]
        public void SearchedTextShouldBeAtPointZero(string expected)
        {
            GoogleSearchResultPage resultPage = Page.GoogleMain.SearchText(expected);
            StringAssert.Contains(expected, resultPage.ResultList[0].Text, "The result list should contains {expected}");
        }

        #endregion
    }
}
