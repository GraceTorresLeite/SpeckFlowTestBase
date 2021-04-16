Feature: ForgotPassword
	As a registered customer
	I want to recover my password
	To access my profile 

@mytag
Scenario: Password recovery successfully
	Given  that I type the URL in my browser
	And I click on the Sign In button to register
	And I click in link Forgot your password
	And I insert Email valid 
	When I click in retrieve password
	Then a message success will be displayed 

Scenario: Password recovery unsuccessful - Required field
    Given  that I type the URL in my browser
	And I click on the Sign In button to register
	And I click in link Forgot your password
	And I insert Email invalid 
	When I click in retrieve password
	Then a message error will be displayed

Scenario: Password recovery unsuccessful - No registry
	Given  that I type the URL in my browser
	And I click on the Sign In button to register
	And I click in link Forgot your password
	And I insert Email invalid 
	When I click in retrieve password
	Then a message error will be displayed