using PageObjectModel.Pages;

using TechTalk.SpecFlow;

namespace PageObjectModel.Steps
{
    /// <summary>
    ///  Declared with Sealed keyword, which enables this class to seal all its variables,
    ///  methods and properties. No other class can inherit anything from this class or in other words,
    ///  this class cannot be inherited. But we can instantiate this class, i.e we can have any number of objects of a sealed class.
    /// </summary>
    /// <remarks>
    /// This file is placeholder to follow POM concepts
    /// </remarks>
    [Binding]
    public sealed class BaseScenarioSteps:BaseSteps
    {
        [Given(@"I navigate to the home page")]
        public void GivenINavigateToTheHomePage()
        {
           InstanceOf<BasePage>().NavigateMainEnterPoint();
        }


    }
}
