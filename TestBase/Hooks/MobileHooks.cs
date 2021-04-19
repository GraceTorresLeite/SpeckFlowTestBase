using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace TestBase.Hooks
{
    [Binding]
    public sealed class MobileHooks
    {
        public static IWebDriver Driver { get; private set; }
        private WebDriverWait _wait;

        [BeforeScenario]
        public void BeforeScenario()
        {
             var deviceSettings = new ChromeMobileEmulationDeviceSettings();
            deviceSettings.Width = 360;
            deviceSettings.Height = 640;
            deviceSettings.UserAgent = "Galaxy S5";

            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.EnableMobileEmulation(deviceSettings);

            Driver = new ChromeDriver(chromeOptions);
            _wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Quit();
        }
    }
}
