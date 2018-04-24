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
            driverService.HideCommandPromptWindow = true;
            var options = new ChromeOptions();
            //Run chromedriver –help to see command line arguments 
            options.AddArgument("--disable-extensions");
            var driver= new ChromeDriver(driverService,options);
            return driver;
        }
    }
}
