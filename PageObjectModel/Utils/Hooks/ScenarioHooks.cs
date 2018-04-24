using System.Linq;
using PageObjectModel.Utils.Selenium;
using TechTalk.SpecFlow;

namespace PageObjectModel.Utils.Hooks
{
    /// <summary>
    /// additional execution logic -> event::Scenario
    /// </summary>
    [Binding]
    internal static class ScenarioHooks
    {
        [BeforeScenario]
        internal static void StartWebDriver()
        {
            // ScenarioContext: Info About State of a scenario
            var tags = ScenarioContext.Current.ScenarioInfo.Tags;
            if (tags.Contains("PhantomJs")) { DriverController.Instance.StartPhantomJs();}
            else if (tags.Contains("Chrome")) { DriverController.Instance.StartChrome();}
            else if (tags.Contains("Debug")) { DriverController.Instance.StartChrome();}
            else DriverController.Instance.StartChrome();
        }
        [AfterScenario]
        internal static void StopWebDriver()
        {
            if (!ScenarioContext.Current.ScenarioInfo.Tags.Contains("Debug")) DriverController.Instance.StopWebDriver();
        }
    }
}
