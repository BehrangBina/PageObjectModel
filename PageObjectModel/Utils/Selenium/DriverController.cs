using System;
using System.Diagnostics;
using OpenQA.Selenium;
using PageObjectModel.Utils.Drivers;

namespace PageObjectModel.Utils.Selenium
{
    internal class DriverController
    {
        internal static DriverController Instance= new DriverController();
        internal IWebDriver WebDriver { get; set; }

        internal void StartChrome()
        {
            if (WebDriver == null) WebDriver = ChromeWebDriver.LoadChromeDriver();
        }

        internal void StartPhantomJs()
        {
            if (WebDriver == null) WebDriver = PhoantomJsWebDriver.LoadPhanomJsDriver();
        }

        internal void StopWebDriver()
        {
            if (WebDriver != null)
            {
                try
                {
                    WebDriver.Quit();
                    WebDriver.Dispose();
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e,":: WebDriver Stop Error" );
                }

                WebDriver = null;
                Console.Out.WriteLine(":: WebDriver Stopped");
            }
        }
    }
}
