Feature: DarkMode

@sanity
Scenario: DarkMode
	Given I launch the application
	And I choose Sign in with Email
	When I enter the username and password as
		| Username             | Password   |
		| testuser19@gmail.com | Parola1377 |
	And I click the Login Button
	Then I see the homepage

	When I go to Settings page
	And I toggle the night mode
	Then the toggle button change its state and is indeed toggled
	And the theme changes to black
	And the dark theme brighness is not greater than 0.3