using System.Linq;
using PageObjectModel.Utils.Selenium;
using TechTalk.SpecFlow;

namespace PageObjectModel.Utils.Hooks
{
    /// <summary>
    /// Hooks which automation logic runs before or after each test run
    /// </summary>
    [Binding]
    internal static class TestRunHooks
    {
        [AfterTestRun]
        internal static void AfterTestRun()
        {
            if (!ScenarioContext.Current.ScenarioInfo.Tags.Contains("Debug")) DriverController.Instance.StopWebDriver();
        }
    }
}
