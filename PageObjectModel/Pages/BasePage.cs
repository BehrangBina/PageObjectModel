using System;
using NUnit.Framework;
using OpenQA.Selenium;
using PageObjectModel.Utils.Selenium;
using static PageObjectModel.Utils.Selenium.Driver;
namespace PageObjectModel.Pages
{
    public class BasePage:Page
    {
        public IWebDriver Driver { get; internal set; }
        public string GetTitle => Driver.Title;
        public string GetUrl => Driver.Url;

        public void NavigateMainEnterPoint()
        {
            var url = Settings.BaseURL;
            Browser().Navigate().GoToUrl(url);
            Browser().Manage().Window.Maximize();
        }

        public void ValidatePageTitle(string expectedTitle)
        {
            var currentTile = GetTitle.Contains(expectedTitle);
            var messsage = $":: Title: {GetTitle} - Expected:{expectedTitle}";
            Assert.IsTrue(currentTile,$"#Error: {messsage}");
            Console.Out.WriteLine(messsage);
        }

        public void ValidatePageUrl(string expectedUrl)
        {
            var currentUrl = GetUrl.Contains(expectedUrl);
            var messsage = $":: URL: {GetTitle} - Expected:{expectedUrl}";
            Assert.IsTrue(currentUrl, $"#Error: {messsage}");
            Console.Out.WriteLine(messsage);
        }
    }
}
