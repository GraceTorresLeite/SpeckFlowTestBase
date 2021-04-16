Feature: Search
	As a person
	I want to be able to type a search
	To find specific items

@searchtag
Scenario: Search - Successfully
	Given  that I type the URL in my browser
	And I insert a word in the search field
	When And click on the search button
	Then results will be displayed

Scenario: Search - Successfully related items
	Given  that I type the URL in my browser
	And I insert a word in the search field
	When And click on the search button
	Then results will be displayed

Scenario: Search - select item from the list of suggestions after 3 letters typed
	Given  that I type the URL in my browser
	And I insert a word in the search field
	When click on the first item in the list
	Then  I will have the visibility of the chosen product "http://automationpractice.com/index.php?id_product=5&controller=product"

Scenario: Search - not found
	Given  that I type the URL in my browser
	And I insert a word in the search field
	When And click on the search button
	Then the alert warning "No results were found for your search" will be visible