Feature: Login
	As a registered customer
	I want to login
	To access my profile 

@logintag
Scenario: Login - successfully
	Given  that I type the URL in my browser
	And I click on the Sign In button to register
	And I insert the registered email "test_04@test.com"
	And I insert Password valid "12345"
	When I click on the button Sign In to login
	Then I will be directed to my profile

Scenario: Login - password does not match the email provided 
	Given  that I type the URL in my browser
	And I click on the Sign In button to register
	And I insert the registered email "test_04@test.com"
	And I insert Password invalid "12347"
	When I click on the button Sign In to login
	Then a message error will be displayed

Scenario: Login - password does not match the required 
    Given  that I type the URL in my browser
	And I click on the Sign In button to register
	And I insert the registered email "test_04@test.com"
	And I insert Password invalid "123"
	When I click on the button Sign In to login
	Then a message error will be displayed

Scenario: Login - email does not match the required 
    Given  that I type the URL in my browser
	And I click on the Sign In button to register
	And I insert the registered email "test_04@test"
	And I insert Password valid "12345"
	When I click on the button Sign In to login
	Then a message error will be displayed

Scenario: Login - email not found in registered
	Given  that I type the URL in my browser
	And I click on the Sign In button to register
	And I insert the registered email "test_not_found@test.com" 
	And I insert Password valid "12345"
	When I click on the button Sign In to login
	Then a message error will be displayed