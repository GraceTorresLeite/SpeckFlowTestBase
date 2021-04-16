using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestBase.Helpers;
using TestBase.Hooks;
using TestBase.PageObjects.Home;

namespace TestBase.PageObjects.LoginLogout
{
    public class LoginPO
    {
        private IWebDriver _driver;
        public HomeSitePO homeSitePO;
        public Alerts alert;
        private WaitLoads wait;

        private By byInputEmailLogin;
        private By byInputPassword;
        private By byBtnSignInLogin;

        public LoginPO()
        {
            _driver = WebHooks.Driver;
            homeSitePO = new HomeSitePO();
            alert = new Alerts();
            wait = new WaitLoads();

            byInputEmailLogin = By.Id("email");
            byInputPassword = By.Id("passwd");
            byBtnSignInLogin = By.Id("SubmitLogin");
        }

        public void InputEmailAndPasswordForLogin(string email, string password)
        {
            _driver.FindElement(byInputEmailLogin).SendKeys(email);
            _driver.FindElement(byInputPassword).SendKeys(password);
        }

        public void InputEmailForLogin(string email)
        {
            _driver.FindElement(byInputEmailLogin).SendKeys(email);
        }

        public void InputPasswordForLogin(string password)
        {
            _driver.FindElement(byInputPassword).SendKeys(password);
        }

        public void BtnSignInLogin()
        {
            _driver.FindElement(byBtnSignInLogin).Submit();
            wait.ToWaitPage(6);
        }
    }
}
