using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using TestBase.Hooks;
using TestBase.PageObjects.LoginLogout;

namespace TestBase.Steps
{
    [Binding]
    public class ForgotPasswordSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver _driver;
        private ForgotPasswordPO _forgotPasswordPO;
        private WebDriverWait _waitDriver;
        public ForgotPasswordSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = WebHooks.Driver;
            _forgotPasswordPO = new ForgotPasswordPO();
        }

        [Given(@"I click in link Forgot your password")]
        public void GivenIClickInLinkForgotYourPassword()
        {
            _forgotPasswordPO.ClickLinkForgotPassword();
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }
        
        //[Given(@"I insert Email valid")]
        //public void GivenIInsertEmailValid()
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        //[Given(@"I insert Email invalid")]
        //public void GivenIInsertEmailInvalid()
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        [When(@"I click in retrieve password")]
        public void WhenIClickInRetrievePassword()
        {
            _forgotPasswordPO.ClickBtnRetrievePassword();
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        [Then(@"a message success ""(.*)"" will be displayed")]
        public void ThenAMessageSuccessWillBeDisplayed(string p0)
        {
            _waitDriver = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            bool equals = _waitDriver.Until(drv => _forgotPasswordPO.alert.IsPageWithAlertDisplayed(p0));
            Assert.IsTrue(equals);
        }

    }
}
