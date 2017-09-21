using OpenQA.Selenium.Support.PageObjects;
using System;

namespace SeleniumGoogleSearch.Pages
{
    public static class Page
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            //            PageFactory.InitElements(Browser.GetDriver, page);
            RetryingElementLocator retry = new RetryingElementLocator(Browser.GetDriver, TimeSpan.FromSeconds(5));
            IPageObjectMemberDecorator decor = new DefaultPageObjectMemberDecorator();
            PageFactory.InitElements(retry.SearchContext, page, decor);
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
