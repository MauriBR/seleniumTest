Feature: TestAutomation
	Test the website functionality
	

@mytag
Scenario: Login to the website 
	Given I am on the website
	And I want to log in
	When I enter the credentials
	And I click the login button
	Then I should be logged in
	