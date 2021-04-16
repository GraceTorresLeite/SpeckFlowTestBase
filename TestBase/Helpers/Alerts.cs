using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using TestBase.Hooks;

namespace TestBase.Helpers
{
    public class Alerts
    {
        private IWebDriver _driver;
        private By byAlertSuccess;
        private By byAlertError;
        private By byAlertWarning;

        private By byAlertList;

        private By byAlertWarningParagraph;

        private By byAlertSuccessForgotParagraph;
        private By byAlertErrorForgotLine;

        public Alerts()
        {
            _driver = WebHooks.Driver;
            byAlertSuccess = By.CssSelector("");
            byAlertError = By.ClassName("alert-danger");
            byAlertWarning = By.ClassName("alert-warning");

            byAlertList = By.CssSelector("ol>li");

            byAlertWarningParagraph = By.CssSelector("#center_column > p");

            byAlertSuccessForgotParagraph = By.CssSelector("#center_column > div > p");
            byAlertErrorForgotLine = By.CssSelector("#center_column > div > div > ol > li");
        }

        public bool IsPageWithAlertDisplayed(string text)
        {
            var titleSelect = _driver.FindElement(byAlertSuccessForgotParagraph).Text;
            var element = _driver.FindElement(byAlertSuccessForgotParagraph);
            if (text.Equals(titleSelect, StringComparison.OrdinalIgnoreCase))
            {
                return element.Displayed;
            }
            throw new NotFoundException($"Element with title {text} was not found");
        }

        public bool IsPageWithAlertWarningDisplayed(string text)
        {
            var titleSelect = _driver.FindElement(byAlertWarning).Text;
            var element = _driver.FindElement(byAlertWarningParagraph);

            int startIndex = 0;
            int length = 37;
            String substring = titleSelect.Substring(startIndex, length);

            if (text.Contains(substring, StringComparison.OrdinalIgnoreCase))
            {
                return element.Displayed;
            }
            throw new NotFoundException($"Element with title {text} was not found");
        }


        public bool IsPageWithNumberAndTextAlerts(string text, int numberAlerts)
        {
            var titleSelect = _driver.FindElement(byAlertErrorForgotLine).Text;
            var element = _driver.FindElement(byAlertErrorForgotLine);
            if (text.Equals(titleSelect, StringComparison.OrdinalIgnoreCase))
            {
                return element.Displayed;
            }
            throw new NotFoundException($"Element with title {text} was not found");

            List<string> errors = new List<string>();
            var selectWrapper = _driver.FindElement(byAlertError);
            var selectAlertLine = selectWrapper
                .FindElements(byAlertList)
                .ToList();

            errors.ForEach(line =>
            {
                selectAlertLine
                .Where(e => e.Text.Contains(line))
                .ToList();

            });

            if (selectAlertLine.Count.Equals(numberAlerts))
            {
                errors.Add(selectAlertLine.ToString());
                return true;
            }
            throw new NotFoundException($"Expected {numberAlerts} but returned {selectAlertLine.Count}");
        }

        public bool IsAlertCount(int numberAlerts)
        {
            List<string> errors = new List<string>();
            var selectWrapper = _driver.FindElement(byAlertError);
            var selectAlertLine = selectWrapper
                .FindElements(byAlertList)
                .ToList();

            errors.ForEach(line =>
            {
                selectAlertLine
                .Where(e => e.Text.Contains(line))
                .ToList();

            });

            if (selectAlertLine.Count.Equals(numberAlerts))
            {
                errors.Add(selectAlertLine.ToString());
                return true;
            }
            throw new NotFoundException($"Expected {numberAlerts} but returned {selectAlertLine.Count}");
        }
    }
}
