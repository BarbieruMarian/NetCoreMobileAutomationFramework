Feature: SendMessageFeature

@sanity
Scenario: SendMessageFeature
	Given I launch the application
	And I choose Sign in with Email
	When I enter the username and password as
		| Username             | Password   |
		| testuser19@gmail.com | Parola1377 |
	And I click the Login Button
	Then I see the homepage

	Given I go to the chats page
	And I select first person from chats
	When I send him a message
	Then that user recives it and this can be proven by checking the database