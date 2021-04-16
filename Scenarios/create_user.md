# 1- Feature: CreateUser

## Story: 
	As a new customer 

	I would like to access the Sign in page

    	So be able to register at the online store.

### Scenario 1: Created user successfully

	Given that I dont have register user

	And I click on the Sign In button

	When insert valid e-mail

	And click in Create an Account

	When insert all required data

	And click in Register

	Then I will be directed to My account profile with my full name signed to the right of the navbar


### Scenario 2: Error - Create an account with an existing email

	Given I inserted an <Email_Exists> already registered

	When click in Create an Account

	Then a  message error will be displayed 


###  Scenario 3: Error - Create an account with an invalid email

       Given I inserted an <Email_Invalid> already registered

       When click in Create an Account

       Then a  message error will be displayed 


###  Scenario 4: Error - invalid mandatory fields

	Given I fill in an invalid mandatory field

	When click in Register

	Then a alert error will be displayed
