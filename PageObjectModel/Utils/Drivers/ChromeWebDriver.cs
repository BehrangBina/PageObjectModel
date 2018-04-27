using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PageObjectModel.Utils.Drivers
{
    internal static class ChromeWebDriver
    {
        internal static IWebDriver LoadChromeDriver()
        {
            //Hide Command Prompt
            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = false;
            var options = new ChromeOptions();
            //Run chromedriver –help to see command line arguments 
            options.AddArgument("--disable-extensions");
            var driver= new ChromeDriver(driverService,options);
            var handle = driver.WindowHandles;
            if (handle.Count > 1)
            {
                driver.SwitchTo().Window(handle.ElementAt(1)).Close();
                driver.SwitchTo().Window(handle.ElementAt(0));
            }
            return driver;
        }
    }
}
