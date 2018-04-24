using OpenQA.Selenium;
using OpenQA.Selenium.PhantomJS;

namespace PageObjectModel.Utils.Drivers
{
    internal static class PhoantomJsWebDriver
    {
        internal static IWebDriver LoadPhanomJsDriver()
        {
            var driverService = PhantomJSDriverService.CreateDefaultService();
            driverService.IgnoreSslErrors = true;
            driverService.LoadImages = false;
            driverService.Proxy = "none";
            driverService.HideCommandPromptWindow = true;
            var driver= new PhantomJSDriver(driverService);
            return driver;
        } 
    }
}
