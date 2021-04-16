using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestBase.Helpers;
using TestBase.Hooks;
using TestBase.PageObjects.Home;

namespace TestBase.PageObjects.LoginLogout
{
    public class CreateUserPO
    {
        private IWebDriver _driver;
        public HomeSitePO access;
        public Alerts alerts;
        private WaitLoads wait;

        private By byInputEmail;
        private By byBtnCreateAnAccount;

        private By byInputGender;
        private By byInputFirstName;
        private By byInputLastName;
        private By byInputPassword;

        private By byOptionDayDateBirth;
        private By byOptionMonthDateBirth;
        private By byOptionYearDateBirth;

        private By byInputAddressFirstName;
        private By byInputAddressLastName;
        private By byInputAddress;
        private By byInputCity;
        private By bySelectState;
        private By byInputPostalCode;
        private By bySelectCountry;
        private By byInputMobilePhone;

        private By byBtnRegister;

        public CreateUserPO()
        {
            _driver = WebHooks.Driver;
            access = new HomeSitePO();
            alerts = new Alerts();
            wait = new WaitLoads();

            byInputEmail = By.CssSelector("#email_create");
            byBtnCreateAnAccount = By.Id("SubmitCreate");

            byInputGender = By.CssSelector("input#id_gender2");
            byInputFirstName = By.Id("customer_firstname");
            byInputLastName = By.Id("customer_lastname");
            byInputPassword = By.Id("passwd");

            byOptionDayDateBirth = By.XPath("//select[@id='days']/option[2]");
            byOptionMonthDateBirth = By.XPath("//select[@id='months']/option[3]");
            byOptionYearDateBirth = By.XPath("//*[@id='years']/option[13]");

            byInputAddressFirstName = By.Id("firstname");
            byInputAddressLastName = By.Id("lastname");
            byInputAddress = By.Id("address1");
            byInputCity = By.Id("city");
            bySelectState = By.CssSelector("#id_state > option:nth-child(2)");
            byInputPostalCode = By.Id("postcode");
            bySelectCountry = By.CssSelector("#id_country > option:nth-child(2)");
            byInputMobilePhone = By.Id("phone_mobile");

            byBtnRegister = By.Id("submitAccount");
        }

        public void InputEmailForCreateUser(string email)
        {
            _driver.FindElement(byInputEmail).SendKeys(email);
        }

        public void BtnCreateAccount()
        {
            _driver.FindElement(byBtnCreateAnAccount).Submit();
        }

        public void BtnRegister()
        {
            _driver.FindElement(byBtnRegister).Submit();
            wait.ToWaiTImplicit(4);
        }

        public void ToFillForm(
            string firstName,
            string lastName,
            string password,
            string addressFirstName,
            string addressLastName,
            string address,
            string city,
            string postalCode,
            string mobilePhone)
        {
            _driver.FindElements(byInputGender);
            wait.ToWaiTImplicit(5);
            _driver.FindElement(byInputFirstName).SendKeys(firstName);
            _driver.FindElement(byInputLastName).SendKeys(lastName);
            _driver.FindElement(byInputPassword).SendKeys(password);
            _driver.FindElement(byOptionDayDateBirth).Click();
            wait.ToWaiTImplicit(3);
            _driver.FindElement(byOptionMonthDateBirth).Click();
            wait.ToWaiTImplicit(3);
            _driver.FindElement(byOptionYearDateBirth).Click();
            wait.ToWaiTImplicit(3);
            _driver.FindElement(byInputAddressFirstName).SendKeys(addressFirstName);
            _driver.FindElement(byInputAddressLastName).SendKeys(addressLastName);
            _driver.FindElement(byInputAddress).SendKeys(address);
            _driver.FindElement(byInputCity).SendKeys(city);
            _driver.FindElement(bySelectState).Click();
            _driver.FindElement(byInputPostalCode).SendKeys(postalCode);
            _driver.FindElement(bySelectCountry).Click();
            _driver.FindElement(byInputMobilePhone).SendKeys(mobilePhone);
            wait.ToWaitPage(3);
        }
    }
}
