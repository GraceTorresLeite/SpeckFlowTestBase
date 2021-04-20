using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading;
using TechTalk.SpecFlow;
using TestBase.Helpers;
using TestBase.Hooks;
using TestBase.PageObjects.Filter;

namespace TestBase.Steps
{
    [Binding]
    public class FiltersSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver _driver;
        private FiltersPO _filtersPO;
        public FiltersPO _filtersMobilePO;
        private WebDriverWait _waitDriver;
        private WaitLoads _wait;
        private HttpClient httpClient;

        public FiltersSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = WebHooks.Driver;
            _filtersPO = new FiltersPO();
            _filtersMobilePO = new FiltersPO(_driver);
            _wait = new WaitLoads();
            httpClient = new HttpClient();
        }

        [When(@"I click on the option category")]
        public void WhenIClickOnTheOptionCategory()
        {
            _filtersPO.ToFilterMenuCategories();
        }

        [Given(@"I click on the option category")]
        public void GivenIClickOnTheOptionCategory()
        {
            _filtersPO.ToFilterMenuCategories();
        }

        [When(@"I click on the option subcategory")]
        public void WhenIClickOnTheOptionSubcategory()
        {
            _filtersPO.ToFilterSubcategories();
        }

        [Then(@"I click on the option subcategory")]
        public void GivenIClickOnTheOptionSubcategory()
        {
            _filtersPO.ToFilterSubcategories();
        }

        [When(@"I click on the option view")]
        public void WhenIClickOnTheOptionView()
        {
            _filtersPO.IsViewList();
        }
        [Then(@"view will be displayed")]
        public void ThenViewWillBeDisplayed()
        {
           bool isGrid=  _filtersPO.IsViewDisplayed();
            Assert.IsTrue(isGrid);
        }

        [When(@"I click on the sort By field")]
        public void WhenIClickOnTheSortByField()
        {
            Assert.AreEqual(1, _filtersPO.SortProductsSelected.Count());
        }

        [Then(@"a list of options will be displayed")]
        public void ThenAListOfOptionsWillBeDisplayed()
        {
            Assert.AreEqual(8,_filtersPO.SortProductsList.Count());
            _wait.ToWaiTImplicit(2);
        }

        [When(@"I click on the box")]
        public void WhenIClickOnTheBox()
        {
            _filtersPO.ToSelectBox();
            Thread.Sleep(TimeSpan.FromSeconds(3));
        }

        [Then(@"a loading error occurs")]
        public void ThenALoadingErrorOccurs()
        {
            _waitDriver = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            bool forbiden = _waitDriver.Until(drv => _filtersPO.IsPageBoxDisplayed());
            Assert.IsTrue(forbiden);
        }



        [Given(@"that I type the URL in my browser mobile")]
        public void GivenThatITypeTheURLInMyBrowserMobile()
        {
            _filtersMobilePO.HomeSiteMobile();
            Thread.Sleep(TimeSpan.FromSeconds(3));
        }


        [When(@"I click on more categories options")]
        public void WhenIClickOnMoreCategoriesOptions()
        {
            _filtersMobilePO.ClickCategorytMobile();
            Thread.Sleep(TimeSpan.FromSeconds(3));
        }

        [Then(@"view mobile will be displayed")]
        public void ThenViewMobileWillBeDisplayed()
        {
            bool ismobile = _filtersMobilePO.ToMobile360x640;
            Assert.IsTrue(ismobile);
        }

        [When(@"I click on the category Woman")]
        public void WhenIClickOnTheCategoryWoman()
        {
            _filtersMobilePO.ClickCategoriesListMobile();
        }

        [Then(@"the page mobile be displayed")]
        public void ThenThePageMobileBeDisplayed()
        {
            bool isTitle = _filtersMobilePO.ToMobile360x640;
            Assert.IsTrue(isTitle);
        }

    }
}
