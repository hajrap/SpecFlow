Feature: LogintoWebsite
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers


Scenario: Add two numbers
	Given Navigate to ASG Website
	When I enter UserID and Password and click Submit
	Then I see welcome to MyAsg page
