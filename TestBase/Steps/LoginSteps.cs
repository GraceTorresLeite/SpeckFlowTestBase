using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;
using TestBase.Helpers;
using TestBase.Hooks;
using TestBase.PageObjects.LoginLogout;

namespace TestBase.Steps
{
    [Binding]
    public class LoginSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver _driver;
        private LoginPO _loginPO;
        private WaitLoads _wait;
        private WebDriverWait _waitDriver;

        public LoginSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = WebHooks.Driver;
            _wait = new WaitLoads();
            _loginPO = new LoginPO();
        }

        [Given(@"I insert Password valid ""(.*)""")]
        public void GivenIInsertPasswordValid(int p0)
        {
            string password = p0.ToString();
            _loginPO.InputPasswordForLogin(password);
        }


        [Given(@"I insert Password invalid ""(.*)""")]
        public void GivenIInsertPasswordInvalid(int p0)
        {
            string password = p0.ToString();
            _loginPO.InputPasswordForLogin(password);
        }


        [Given(@"I insert the registered email ""(.*)""")]
        public void GivenIInsertTheRegisteredEmail(string p0)
        {
            _loginPO.InputEmailForLogin(p0);
        }


        [When(@"I click on the button Sign In to login")]
        public void WhenIClickOnTheButtonSignInToLogin()
        {
            _loginPO.BtnSignInLogin();
        }
    }
}
