Feature: SignIn
	User whould have to sign in to use the giftrete website

@mytag
Scenario: Sign in
	Given I navigate to site "https://www.qa.giftrete.com/"
	And I click on sign in
	When I enter email and password 
	| Email                  | Password|
	| mclight07@hotmail.co.uk| Apotieri1 |
	And I click sign in
	Then my home page should be displayed
	And I sign out


