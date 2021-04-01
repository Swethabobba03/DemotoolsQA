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
    public class TextboxSteps : BasePage
    {
        private readonly ElementsPage _elementsPage;
        private readonly bool _IsPageReady = false;

        public TextboxSteps(IWebDriver browser) : base(browser)
        {
            _browser = browser;
            _elementsPage = new ElementsPage(_browser);
        }

        [Given(@"I open Tools QA Website")]
        public void GivenIOpenToolsQAWebsite()
        {
            _browser.Navigate().GoToUrl(ConfigurationManager.GetJsonConfig.Url);
        }

        [Given(@"I click on Elements Page")]
        public void GivenIClickOnElementsPage()
        {

            _seleniumExtGeneral.MovetoElement(_elementsPage.ElementsButton);
            _seleniumExtGeneral.Wait(_IsPageReady, 5);
        }


        [Then(@"I click on Text Box Button")]
        public void ThenIClickOnTextBoxButton()
        {
            _seleniumExtGeneral.Wait(_IsPageReady, 5);
            _elementsPage.TextBoxButton.Click();
            _seleniumExtGeneral.Wait(_IsPageReady, 5);
        }

    }
}
