Feature: BottomMenusNavigation


@sanity
Scenario: Stress test bottom navigation menus
	Given I launch the application
	And I choose Sign in with Email
	When I enter the username and password as
		| Username             | Password   |
		| testuser19@gmail.com | Parola1377 |
	And I click the Login Button
	Then I see the homepage
	And I click the Settings Tab
	When I keep changing the tabs many times
	Then I go back to the Home Page