## 4 - Feature: ForgotPassword

## Story: 

	I as a registered customer but for a long time without making purchases in the virtual store, 

	I would like to be able to recover my password 

	to be able to login.


### Scenario: Password recovery successfully

	Given that I want to access the online store with my profile

	When I click on the link Sign In

	And I click in link Forgot your password

	And insert a email valid

	When I click in retrieve password

	Then the a success message "A confirmation email has been sent to your address: test_04@test.com" will be visible


### Scenario: Password recovery unsuccessful - Required field

	Given that I want to access the online store with my profile

	When I click on the link Sign In

	And I click in link Forgot your password

	And insert an email without the required data

	When I click in retrieve password

	Then the a error message "Invalid email address." will be visible


### Scenario: Password recovery unsuccessful - No registry

	Given that I want to access the online store with my profile

	When I click on the link Sign In

	And I click in link Forgot your password

	And insert an unregistered email into the system

	When I click in retrieve password

	Then the a error message "There is no account registered for this email address." will be visible
