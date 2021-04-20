Feature: Filters and Layouts
	As a person
	I want to access the category "Women"
	And change the way products are presented

@filterstag
Scenario: Select menu categories
	Given  that I type the URL in my browser
	When I click on the option category
	Then results will be displayed "There are 7 products."

Scenario: Select subcategory 
	Given  that I type the URL in my browser
	And I click on the option category
	When  I click on the option subcategory
	Then results will be displayed "There are 2 products."

Scenario: Select subcategory by subcategories from the menu on the previous page
	Given  that I type the URL in my browser
	And I click on the option category
	When  I click on the option subcategory
	And  I click on the option subcategory
	Then results will be displayed "There is 1 product."

Scenario: Select view
	Given  that I type the URL in my browser
	And I click on the option category
	When  I click on the option view
	Then view will be displayed

Scenario: List options sort by
	Given  that I type the URL in my browser
	And I click on the option category
	When  I click on the sort By field
	Then a list of options will be displayed

Scenario: Select box in catalog
	Given  that I type the URL in my browser
	And I click on the option category
	When  I click on the box 
	Then a loading error occurs

Scenario: Select menu categories in mobile Galaxy S5
	Given  that I type the URL in my browser mobile
	When  I click on more categories options 
	Then view mobile will be displayed


Scenario: Select category in mobile Galaxy S5
	Given  that I type the URL in my browser mobile
	When  I click on more categories options 
	And  I click on the category Woman
	Then the page mobile be displayed