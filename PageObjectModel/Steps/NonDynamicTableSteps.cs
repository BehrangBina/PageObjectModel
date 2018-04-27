using PageObjectModel.Pages;
using TechTalk.SpecFlow;

namespace PageObjectModel.Steps
{
    public sealed class NonDynamicTableSteps:BaseSteps
    {
        [Then(@"I can see")]
        public void ThenICanSee(Table table)
        {
            InstanceOf<BasePage>().ValidateMultipleTextInPageSourece(table);
        }
    }
}
