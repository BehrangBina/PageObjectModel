using OpenQA.Selenium;
using PageObjectModel.Utils.Selenium;
using static PageObjectModel.Utils.Selenium.Driver;
namespace PageObjectModel.Pages
{
    public class BasePage:Page
    {
        public IWebDriver Driver { get; internal set; }

        public void NavigateMainEnterPoint()
        {
            var url = Settings.BaseURL;
            Browser().Navigate().GoToUrl(url);
            Browser().Manage().Window.Maximize();
        }

    }
}
