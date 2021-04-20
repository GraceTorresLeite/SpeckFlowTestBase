using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TestBase.Helpers;
using TestBase.Hooks;
using TestBase.PageObjects.Home;

namespace TestBase.PageObjects.Search
{
    public class SearchPO
    {
        private IWebDriver _driver;
        public HomeSitePO access;
        public Alerts alert;
        private WaitLoads waitLoads;
        public WebDriverWait _waitDriver;

        private By byBtnSearch;
        private By byInputWordSearch;
        private By byActionResult;
        private By byActionSelectFirstLineListResultsSearch;
        private By byResultsProductListFound;

        public SearchPO()
        {
            _driver = WebHooks.Driver;
            access = new HomeSitePO();
            alert = new Alerts();
            waitLoads = new WaitLoads();

            byBtnSearch = By.Name("submit_search");
            byInputWordSearch = By.Id("search_query_top");
            byActionResult = By.XPath("//*[@id='index']/div[2]");
            byActionSelectFirstLineListResultsSearch = By.XPath("//*[@id='index']/div[2]/ul/li[1]");
            byResultsProductListFound = By.CssSelector("#center_column > h1 > span.heading-counter");
        }

        public string titleSelect => _driver.FindElement(byResultsProductListFound).Text;
       
        public void ToFillWord(string name)
        {
            var valueField = _driver.FindElement(byInputWordSearch);
            valueField.Clear();
            valueField.SendKeys(name);
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }
        public void BtnSearch()
        {
            _driver.FindElement(byBtnSearch).Submit();
            waitLoads.ToWaitPage(5);
        }

        public bool IsUrl(string url)
        {
            _driver.Url.Contains(url);
            return true;
        }

        public void ToFillWordWith3Letters(string name)
        {
            var valueField = _driver.FindElement(byInputWordSearch);
            valueField.Clear();
            valueField.SendKeys(name);
            waitLoads.ToWaitElement(5, byActionResult);

           // _waitDriver = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
           // _waitDriver.Until(ExpectedConditions.ElementToBeClickable(By.Id("id"))).Click();

            _driver.FindElement(byActionSelectFirstLineListResultsSearch).Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }

            public bool IsPageWithSearchDisplayed(string text)
        {
            var titleSelect = _driver.FindElement(byResultsProductListFound).Text;
            var element = _driver.FindElement(byResultsProductListFound);

            if (text.Contains(titleSelect, StringComparison.OrdinalIgnoreCase))
            {
                return element.Displayed;
            }
            throw new NotFoundException($"Element with title {text} was not found");
        }
    }

}
