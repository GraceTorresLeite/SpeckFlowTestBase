using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestBase.Helpers;
using TestBase.Hooks;
using TestBase.PageObjects.Home;

namespace TestBase.PageObjects.LoginLogout
{
    public class ForgotPasswordPO
    {
        private IWebDriver _driver;
        public HomeSitePO homeSitePO;
        public LoginPO loginPO;
        public Alerts alert;
        private WaitLoads wait;

        private By byLinkForgot;
        private By byFormForgot;
        private By bySelectRetrievePassword;
       
        public ForgotPasswordPO()
        {
            _driver = WebHooks.Driver;
            homeSitePO = new HomeSitePO();
            loginPO = new LoginPO();
            alert = new Alerts();
            wait = new WaitLoads();

            byLinkForgot = By.CssSelector("#login_form .form-group.lost_password a");
            byFormForgot = By.Id("form_forgotpassword");
            bySelectRetrievePassword = By.CssSelector("fieldset > p > button");
        }

        public void ClickLinkForgotPassword()
        {
            _driver.FindElement(byLinkForgot).Click();
        }
        public void ClickBtnRetrievePassword()
        {
            var idForm = _driver.FindElement(byFormForgot);
            var elements = idForm.FindElement(bySelectRetrievePassword);
            elements.Click();
            wait.ToWaiTImplicit(5);
        }

    }
}
