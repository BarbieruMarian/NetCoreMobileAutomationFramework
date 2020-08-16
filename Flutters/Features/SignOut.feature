Feature: SignOut

@mytag
Scenario: SignOut
	Given I launch the application
	And I choose Sign in with Email
	When I enter the username and password as
		| Username             | Password   |
		| testuser19@gmail.com | Parola1377 |
	And I click the Login Button
	Then I see the homepage

	When I navigate to settings page
	And I press the Sign Out Button
	Then the application is closed and the screen goes back to the login screen