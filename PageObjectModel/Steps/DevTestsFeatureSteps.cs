using System;
using NUnit.Framework;
using PageObjectModel.Pages;
using TechTalk.SpecFlow;

namespace PageObjectModel.Steps
{
    [Binding]
    public class DevTestsFeatureSteps:BaseSteps
    {
        [Given(@"I click on English link")]
        public void GivenIClickOnEnglishLink()
        {
            InstanceOf<BasePage>().NavigateMainEnterPoint();
        }
        
        [Then(@"I can Navigate to english page")]
        public void ThenICanNavigateToEnglishPage()
        {
          var englishPage= InstanceOf<BasePage>().NavEnglishHomePage();
            Assert.IsTrue(englishPage.Driver.Title.Contains("Main_Page"));
        }
    }
}
