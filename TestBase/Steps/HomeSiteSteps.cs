using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;
using TestBase.Helpers;
using TestBase.Hooks;
using TestBase.PageObjects.Home;

namespace TestBase.Steps
{
    [Binding]
    public class HomeSiteSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver _driver;
        private HomeSitePO _homeSitePO;
        private WaitLoads _wait;
        private WebDriverWait _waitDriver;

        public HomeSiteSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = WebHooks.Driver;
            _wait = new WaitLoads(5);
            _homeSitePO = new HomeSitePO();
        }

        [Given(@"that I type the URL in my browser")]
        public void GivenThatITypeTheURLInMyBrowser()
        {
            _homeSitePO.HomeSite();
        }
        
        [Then(@"I will have access to home page")]
        public void ThenIWillHaveAccessToHomePage()
        {
            Assert.IsTrue(_homeSitePO.IsHomePageVisible);
            
        }
    }
}
