using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TestBase.Hooks;

namespace TestBase.Helpers
{
    public class WaitLoads
    {
        private IWebDriver _driver;
        public WebDriverWait _wait;

        public WaitLoads(int time)
        {
            _driver = WebHooks.Driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(time));
        }

        public WaitLoads()
        {
            _driver = WebHooks.Driver;
        }

        public void ToWaitElement(int time, By element)
        {
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(time));
            _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(element));
        }

        public void ToWaitPage(int time)
        {
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(time);
        }

        public void ToWaiTImplicit(int time)
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(time);
        }
    }
}
