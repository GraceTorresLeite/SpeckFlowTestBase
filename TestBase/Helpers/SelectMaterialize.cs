using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestBase.Hooks;

namespace TestBase.Helpers
{
    public class SelectMaterialize
    {
        private IWebDriver _driver;
        private IWebElement selectWrapper;
        private IEnumerable<IWebElement> options;

        public SelectMaterialize(IWebDriver driver , By locatorWrapper, By locatorUlLi)
        {
            _driver = driver;
            driver = WebHooks.Driver;
            selectWrapper = driver.FindElement(locatorWrapper);
            options = selectWrapper.FindElements(locatorUlLi);
        }

        public SelectMaterialize(IWebDriver driver, By locatorWrapper)
        {
            _driver = driver;
            driver = WebHooks.Driver;
            selectWrapper = driver.FindElement(locatorWrapper);
            options = selectWrapper.FindElements(By.CssSelector("li>span"));
        }

        public IEnumerable<IWebElement> Options => options;

        private void OpenWrapper()
        {
            selectWrapper.Click();
        }

        public void SelectByText(string option)
        {
            OpenWrapper();
            options
                .Where(o => o.Text.Contains(option))
                .ToList()
                .First()
                .Click();
        }
    }
}
