using OpenQA.Selenium;
using System;
using TestBase.Helpers;
using TestBase.Hooks;

namespace TestBase.PageObjects.Home
{
    public class HomeSitePO
    {
        private IWebDriver _driver;
        public WaitLoads wait;
        private By byLinkSignIn;
        private By byLinkSignOut;
        private By byTitle;
        private By byHomeSite;

        public HomeSitePO()
        {
            _driver = WebHooks.Driver;
            wait = new WaitLoads();
            byLinkSignIn = By.CssSelector("a.login");
            byLinkSignOut = By.ClassName("logout");
            byTitle = By.TagName("h1");
            byHomeSite = By.Id("header_logo");
        }

        public static string _TITLE_MY_ACCOUNT = "My account";

        public void HomeSite()
        {
            _driver.Navigate().GoToUrl("http://automationpractice.com/index.php");         
        }

        public bool IsHomePageVisible => _driver.FindElement(byHomeSite).Displayed;
       
        public void BtnSignInLink()
        {
            _driver.FindElement(byLinkSignIn).Click();
            wait.ToWaiTImplicit(6);
        }

        public void BtnSignOutLink()
        {
            _driver.FindElement(byLinkSignOut).Click();
            wait.ToWaitPage(5);
        }

        public int CountString(string text, int startIndex, int length)
        {
            String number = text;
            return int.Parse(number.Substring(startIndex, length));
        }

        public bool IsPageMyAccountVisible
        {
            get
            {
                var titleSelect = _driver.FindElement(byTitle).Text;
                var element = _driver.FindElement(byTitle);
                if (_TITLE_MY_ACCOUNT.ToUpper().Equals(titleSelect))
                {
                    return element.Displayed;
                }
                throw new NotFoundException($"Element with title {_TITLE_MY_ACCOUNT} was not found");

            }
        }
    }
}
