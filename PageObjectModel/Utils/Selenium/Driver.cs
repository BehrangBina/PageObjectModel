using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace PageObjectModel.Utils.Selenium
{
    [Binding]
    internal class Driver
    {
        internal static IWebDriver Browser()  =>  DriverController.Instance.WebDriver;

    
    }
}
