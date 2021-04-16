# 2 - Feature: CreateUser

## Story: 

	As a new customer

	I want to register

	To have a profile linked to the site


### Scenario: Created user successfully

	Given  that I type the URL in my browser

	And I click on the Sign In button to register

	And I insert valid e-mail

	And click in Create an Account

	And I fill in all mandatory fields

	When click in Register

	Then I will be directed to my profile


### Scenario: Error - Create an account with an existing email

	Given  that I type the URL in my browser

	And I click on the Sign In button to register

	And I insert an email already registered

	When click in Create an Account

	Then a message error will be displayed 


### Scenario: Error - Create an account with an invalid email

	Given  that I type the URL in my browser

	And I click on the Sign In button to register

	And I insert an invalid email 

	When click in Create an Account

	Then a message error will be displayed 


### Scenario: Error - invalid mandatory fields

	Given  that I type the URL in my browser

	And I click on the Sign In button to register

	And I insert valid e-mail

	And click in Create an Account

	And I do not fill in all mandatory fields

	When click in Register	

	Then a message error will be displayed with the missing data
