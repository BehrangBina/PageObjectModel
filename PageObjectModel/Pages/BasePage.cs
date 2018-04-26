using OpenQA.Selenium;
using static PageObjectModel.Utils.Selenium.Driver;
namespace PageObjectModel.Pages
{
    public class BasePage:Page
    {
        public IWebDriver Driver { get; internal set; }

        public void NavigateMainEnterPoint()
        {
            const string url = ToBeReplacedWithProjectConf.Url;
            Browser().Navigate().GoToUrl(url);
            Browser().Manage().Window.Maximize();
        }

    }
}
