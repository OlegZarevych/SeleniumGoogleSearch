using OpenQA.Selenium.Support.PageObjects;


namespace SeleniumGoogleSearch.Pages
{
    public static class Page
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browser.GetDriver, page);
            return page;
        }

        public static GoogleMainPage GoogleMain
        {
            get { return GetPage<GoogleMainPage>(); }
        }

        public static GoogleSearchResultPage GoogleSearchResult
        {
            get { return GetPage<GoogleSearchResultPage>(); }
        }
    }
}
