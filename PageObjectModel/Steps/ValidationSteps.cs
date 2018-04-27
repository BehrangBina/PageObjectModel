using PageObjectModel.Pages;
using TechTalk.SpecFlow;

namespace PageObjectModel.Steps
{
    public sealed class ValidationSteps:BaseSteps
    {
        [Then(@"I can see the web title ""(.*)""")]
        public void ThenICanSeeTheWebTitle(string expectedTitle)
        {
            InstanceOf<BasePage>().ValidatePageTitle(expectedTitle);
        }
        [Then(@"I can see the web url ""(.*)""")]
        public void ThenICanSeeTheWebUrl(string expectedUrl)
        {
            InstanceOf<BasePage>().ValidatePageUrl(expectedUrl);
        }
    }
}
