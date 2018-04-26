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

        public void NavigateMainEnterPoint()
        {
            var url = Settings.BaseURL;
            Browser().Navigate().GoToUrl(url);
            Browser().Manage().Window.Maximize();
        }

        public void ValidatePageTitle(string expectedTitle)
        {
            var currentTile = Driver.Title.Contains(expectedTitle);
            var messsage = $":: Title: {GetTitle} - Expected:{expectedTitle}";
            Assert.IsTrue(currentTile,$"#Error: {messsage}");
            Console.Out.WriteLine(messsage);
        }
    }
}
