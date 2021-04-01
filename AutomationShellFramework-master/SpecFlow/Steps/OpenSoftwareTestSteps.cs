using Configuration.Config;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Selenium.Models.PageModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlow.Steps
{
    [Binding]
    public class OpenSoftwareTestSteps : BasePage
    {

        private readonly TutorialsPage _tutorialsPage;
        private readonly bool _IsPageReady = false;

        public OpenSoftwareTestSteps(IWebDriver browser) : base(browser)
        {
            _browser = browser;
            _tutorialsPage = new TutorialsPage(_browser);
        }
        [Given(@"I Open ToolsQA website")]
        public void GivenIOpenToolsQAWebsite()
        {
            _browser.Navigate().GoToUrl(ConfigurationManager.GetJsonConfig.Url2);
        }

        [Given(@"I click on Titorial Button")]
        public void GivenIClickOnTitorialButton()
        {
            _seleniumExtGeneral.MovetoElement(_tutorialsPage.TutorialsButton);

        }

        
        //[Given(@"I click QA Practices")]
        //public void GivenIClickQAPractices()
        //{
            
        //}

        //[Given(@"I click Software Testing")]
        //public void GivenIClickSoftwareTesting()
        //{
            
        //}

        //[Then(@"the heading is Software Testing Tutorial")]
        //public void ThenTheHeadingIsSoftwareTestingTutorial()
        //{
            
        //}

    }
}
