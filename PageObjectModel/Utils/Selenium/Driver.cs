using System.ComponentModel;
using OpenQA.Selenium;

namespace PageObjectModel.Utils.Selenium
{
    [Binding]
    internal class Driver
    {
        internal static IWebDriver Browser()
        {
            return DriverController.Instance.WebDriver;
        }
    }
}
