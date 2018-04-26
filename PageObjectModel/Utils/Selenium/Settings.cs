using System.Configuration;

namespace PageObjectModel.Utils.Selenium
{
    public class Settings
    {
        //public const string Url = "http://www.wikipedia.org";
        public static string BaseURL = ConfigurationManager.AppSettings["BaseUrl"];
    }
}
