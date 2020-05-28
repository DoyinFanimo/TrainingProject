Feature: JoinCommunity
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Join public community
	Given I navigate to site "https://www.qa.giftrete.com/"
	And I click on sign in
	When I enter email and password 
	| Email                  | Password|
	| mclight07@hotmail.co.uk| bluesky |
	And I click sign in
	And I click on community
	And I click on the preferred community
	And I click on follow
	Then my community home page should be displayed
