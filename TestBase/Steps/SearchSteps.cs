using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;
using TestBase.Hooks;
using TestBase.PageObjects.Search;

namespace TestBase.Steps
{
    [Binding]
    public class SearchSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver _driver;
        private SearchPO _searchPO;
        private WebDriverWait _waitDriver;

        public SearchSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = WebHooks.Driver;
            _searchPO = new SearchPO();
        }

        [Given(@"I insert word ""(.*)"" in the search field")]
        public void GivenIInsertWordInTheSearchField(string p0)
        {
            _searchPO.ToFillWord(p0);
        }
        
        [When(@"And click on the search button")]
        public void WhenAndClickOnTheSearchButton()
        {
            _searchPO.BtnSearch();
        }
        
        [When(@"click on the first item in the list")]
        public void WhenClickOnTheFirstItemInTheList()
        {
            string name = "dre";
            _searchPO.ToFillWordWith3Letters(name);
        }
        
        [Then(@"results will be displayed ""(.*)""")]
        public void ThenResultsWillBeDisplayed(string p0)
        {
            _waitDriver = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            bool contains = _waitDriver.Until(drv => _searchPO.IsPageWithSearchDisplayed(p0));
            Assert.IsTrue(contains);
        }
        
        [Then(@"I will have the visibility of the chosen product ""(.*)""")]
        public void ThenIWillHaveTheVisibilityOfTheChosenProduct(string p0)
        {
            _waitDriver = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            bool equals = _waitDriver.Until(drv => _searchPO.IsUrl(p0));
            Assert.IsTrue(equals);
        }
        
        [Then(@"the alert warning ""(.*)"" will be visible")]
        public void ThenTheAlertWarningWillBeVisible(string p0)
        {
            _waitDriver = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            bool contains = _waitDriver.Until(drv => _searchPO.alert.IsPageWithAlertWarningDisplayed(p0));
            Assert.IsTrue(contains);
        }
    }
}
