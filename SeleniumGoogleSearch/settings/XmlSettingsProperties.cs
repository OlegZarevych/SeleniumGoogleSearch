
namespace SeleniumGoogleSearch.settings
{
    class XmlSettingsProperties
    {
        public static string Url
        {
            get
            {
                return PropertiesHandler.Instance.FindValue("Url");
            }
        }

        public static string Browser
        {
            get
            {
                return PropertiesHandler.Instance.FindValue("Browser");
            }
        }
    }
}
