Feature: CreateCommunity
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Create Community
	Given I navigate to site "https://www.qa.giftrete.com/"
	And I click on sign in
	When I enter email and password 
	| Email                  | Password|
	| mclight07@hotmail.co.uk| bluesky |
	And I click sign in
	And I click on community
	And I click create
	And I enter community name "Fitness Class"
	And I select community type "Public"
	And I enter community handle "@fitnessclass"
	And I enter community description "To get fit"
	And I select category "4"
	And I enter location "London, UK"
	And I upload an Image "\fitnessImage.jfif"
	And I click create community
	Then my community should be created


@mytag
Scenario: Invalid Create Community
	Given I navigate to site "https://www.qa.giftrete.com/"
	And I click on sign in
	When I enter email and password 
	| Email                  | Password|
	| mclight07@hotmail.co.uk| Apotieri1 |
	And I click sign in
	And I click on community
	And I click create
	And I enter community name "Fitness Class"
	And I select community type "Public"
	And I enter community handle "@fitnessclass"
	And I enter community description "To get fit"
	And I select category "4"
	And I enter location "London, UK"
	#And I upload an Image "\fitnessImage.jfif"
	And I click create community
	Then display error message "Image file name cannot be empty! Please select a valid image file"
