Feature: Browsing
	In order to browse home page
	As a user
	I want to  view home page


Scenario: Navigate to home page
	Given Url homelink
	When I navigate to /www.asg.com.au
	Then I should see home page
