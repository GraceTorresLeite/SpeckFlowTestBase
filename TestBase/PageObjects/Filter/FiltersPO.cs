using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;
using TestBase.Helpers;
using TestBase.Hooks;
using TestBase.PageObjects.Home;

namespace TestBase.PageObjects.Filter
{
    public class FiltersPO
    {
        private IWebDriver _driver;
       // public IWebDriver driver;
        public HomeSitePO access;
        public SelectMaterialize selects;
        public Alerts alert;
        private WaitLoads wait;

        private By byMenuCategories;
        private By bySubCategories;
        private By bySelectLine;

        private By byViewGrid;
        private By byViewList;

        private By bySort;

        private By byBox;

        private By byMenuMobile;
        private By byMobileCatTitle;
        private By byMobileCategory;
        private By byMobileClassGrover;
        public FiltersPO()
        {          
            _driver = WebHooks.Driver;
           // driver = MobileHooks.Driver;
            access = new HomeSitePO();
            alert = new Alerts();
            wait = new WaitLoads();

            byMenuCategories = By.CssSelector("#block_top_menu > ul > li:nth-child(1) > a");

            bySubCategories = By.CssSelector("#subcategories > ul > li:nth-child(1) > h5 > a");

            bySelectLine = By.CssSelector("ul>li>a");

            byViewGrid = By.Id("grid");
            byViewList = By.Id("list");

            bySort = By.Id("selectProductSort");

            byBox = By.Id("layered_category_4");
           // byMenuMobile = By.ClassName("cat-title active");
           // byMobileCatTitle = By.ClassName("cat-title");
           // byMobileClassGrover = By.ClassName("menu-mobile-grover");
           // byMobileCategory = By.CssSelector("//*[@id='block_top_menu']/ul/li[1]/a");
            // byMobileCategory = By.CssSelector("# block_top_menu > ul > li:nth-child(1) > a");
            //*[@id="block_top_menu"]/ul/li[1]/a
            //*[@id="block_top_menu"]/ul/li[1]/a
        }

        public FiltersPO(IWebDriver driver)
        {
            _driver = MobileHooks.Driver;
            driver = _driver;
            
            access = new HomeSitePO();
            alert = new Alerts();
            wait = new WaitLoads();

            byMenuMobile = By.ClassName("cat-title active");
            byMobileCatTitle = By.ClassName("cat-title");
            byMobileClassGrover = By.ClassName("menu-mobile-grover");
            byMobileCategory = By.CssSelector("//*[@id='block_top_menu']/ul/li[1]/a");
           
        }

        public void ToFilterMenuCategories()
        {
            _driver.FindElement(byMenuCategories).Click();
            wait.ToWaitPage(3);
        }

        public void ToFilterSubcategories()
        {
            _driver.FindElement(bySubCategories).Click();
            wait.ToWaitPage(3);
        }

        public void IsViewList()
        {
            _driver.FindElement(byViewList).Click();
            Thread.Sleep(TimeSpan.FromSeconds(3));
        }
        public bool IsViewDisplayed()
        {
            _driver.FindElement(byViewGrid).Click();
            Thread.Sleep(TimeSpan.FromSeconds(3));
            return _driver.FindElement(byViewGrid).Displayed;
        }

        public IEnumerable<string> SortProductsSelected 
        {
            get
            {
                var elementProducts = new SelectElement(_driver.FindElement(bySort));
           
                return elementProducts.Options
                     .Where(o => o.Selected)
                     .Select(o => o.Text);
            }
        }

        public IEnumerable<string> SortProductsList
        {
            get
            {
                var elementProducts = new SelectElement(_driver.FindElement(bySort));
                // elementProducts.FindElements(By.TagName("option"));
                return elementProducts.Options
                     .Where(o => o.Enabled)
                     .Select(o => o.Text);
            }
        }


        #region TESTS MOBILE
        public void HomeSiteMobile()
        {
            _driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        public void ClickCategorytMobile()
        {
            _driver.FindElement(byMobileCatTitle).Click();
        }

        public void ClickCategoriesListMobile()
        {
            _driver.Navigate().GoToUrl("http://automationpractice.com/index.php");        
            _driver.FindElement(byMobileCatTitle).Click();        
            _driver.FindElement(byMobileCategory).Click();
        }

        public bool ToMobile360x640
        {
            get
            {
                var elementMobile = _driver.FindElement(byMobileClassGrover);
                return elementMobile.Displayed;
            }
        }
        #endregion
        public void ToSelectBox()
        {
            _driver.FindElement(byBox).Click();
        }
        public async Task LT_Broken_Links_Test()
        {
            using var client = new HttpClient();

            int valid_links = 0;
            int broken_links = 0;
            var links = _driver.FindElements(By.TagName("a"));
            foreach (var link in links)
            {
                if (!(link.Text.Contains("http://automationpractice.com/"))||(link.Text == "") || link.Text.Equals(null))
                {
                   

                    try
                    {

                        HttpResponseMessage response = await client.GetAsync(link.GetAttribute("href"));
                        Console.WriteLine($"URL: {link.GetAttribute("href")} status is: {response.StatusCode}");
                        if (response.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            valid_links++;
                        }
                        else 
                        {
                            broken_links++;
                        }
                    }
                    catch (Exception ex)
                    {

                        if ((ex is ArgumentNullException) || (ex is NotSupportedException))
                        {
                            Console.WriteLine("Execption occured\n");
                        }
                    }
                }
            }
            Thread.Sleep(2000);
            Console.WriteLine("Detection of broken links completed with " + broken_links + "broken links and " + valid_links + "valid links." );
        }
    }
}
