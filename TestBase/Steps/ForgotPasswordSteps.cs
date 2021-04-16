using System;
using TechTalk.SpecFlow;

namespace TestBase.Steps
{
    [Binding]
    public class ForgotPasswordSteps
    {
        [Given(@"I click in link Forgot your password")]
        public void GivenIClickInLinkForgotYourPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I insert Email valid")]
        public void GivenIInsertEmailValid()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I insert Email invalid")]
        public void GivenIInsertEmailInvalid()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click in retrieve password")]
        public void WhenIClickInRetrievePassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"a message success will be displayed")]
        public void ThenAMessageSuccessWillBeDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
