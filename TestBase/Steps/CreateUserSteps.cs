using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;
using TestBase.Helpers;
using TestBase.Hooks;
using TestBase.PageObjects.Home;
using TestBase.PageObjects.LoginLogout;

namespace TestBase.Steps
{
    [Binding]
    public class CreateUserSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver _driver;
        private CreateUserPO _createUserPO;
        private WaitLoads _wait;
        private WebDriverWait _waitDriver;

        public CreateUserSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = WebHooks.Driver;
            _wait = new WaitLoads();
            _createUserPO = new CreateUserPO();
        }

        [Given(@"I click on the Sign In button to register")]
        public void GivenIClickOnTheSignInButtonToRegister()
        {
            _createUserPO.access.BtnSignInLink();
        }

        [Given(@"I insert valid e-mail")]
        public void GivenIInsertValidE_Mail()
        {
            string email = $"{Guid.NewGuid()}@hotmail.com";
            _createUserPO.InputEmailForCreateUser(email);
        }

        [Given(@"click in Create an Account")]
        public void GivenClickInCreateAnAccount()
        {
            _createUserPO.BtnCreateAccount();
        }

        [Given(@"I fill in all mandatory fields")]
        public void GivenIFillInAllMandatoryFields()
        {
            _createUserPO.ToFillForm(
               "First",
               "Last",
               "12345",
               "FirstAddress",
               "LastAddress",
               "Street",
               "NameCity",
               "00000",
               "99999999999");
        }

        [Given(@"I insert an email already registered")]
        public void GivenIInsertAnEmailAlreadyRegistered()
        {
            _createUserPO.InputEmailForCreateUser("test_04@test.com");
        }

        [Given(@"I insert an invalid email")]
        public void GivenIInsertAnInvalidEmail()
        {
            _createUserPO.InputEmailForCreateUser("test_01@test");
        }

        [Given(@"I do not fill in all mandatory fields")]
        public void GivenIDoNotFillInAllMandatoryFields()
        {
            _createUserPO.ToFillForm(
               "First_Name",
               "Last",
               "12345",
               "FirstAddress",
               "LastAddress",
               "Street",
               "NameCity",
               "00",
               "99999999999");
        }

        [When(@"click in Register")]
        public void WhenClickInRegister()
        {
            _createUserPO.BtnRegister();
        }

        [When(@"click in Create an Account")]
        public void WhenClickInCreateAnAccount()
        {
            _createUserPO.BtnCreateAccount();
        }

        [Then(@"I will be directed to my profile")]
        public void ThenIWillBeDirectedToMyProfile()
        {
            bool equals = _createUserPO.access.IsPageMyAccountVisible;
            _driver.PageSource.Should().Equals(equals);
        }

        [Then(@"a message error will be displayed")]
        public void ThenAMessageErrorWillBeDisplayed()

        {
            _waitDriver = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            bool equals = _createUserPO.alerts.IsAlertCount(1);
            Assert.IsTrue(equals);
        }

        [Then(@"a message error will be displayed with the missing data")]
        public void ThenAMessageErrorWillBeDisplayedWithTheMissingData()
        {
            _waitDriver = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            bool equals = _createUserPO.alerts.IsAlertCount(2);
            Assert.IsTrue(equals);
        }
    }
}
