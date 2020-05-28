Feature: CommunityPage
	This is to ensure  a user can sign up and log in to the giftrete website

@mytag
Scenario Outline: create account 
	Given I navigate to the site https://www.qa.giftrete.com/
	And I click on create account
	When I enter "<FirstName>"
	And I enter "<LastName>
	And I enter "<EmailAddress>"
	And I enter "<PhoneNumber>"
	And I enter "<Password>"
	And I enter "<ConfirmPassword>"
	And I click register
	Then I should be registered
Examples: 
| FirstName | LastName | EmailAddress           | PhoneNumber | Password | ConfirmPassword |
| Ife       | Fanimo   | mclight07@hotmail.co.uk | 07429674992 | bluesky  | bluesky         |





