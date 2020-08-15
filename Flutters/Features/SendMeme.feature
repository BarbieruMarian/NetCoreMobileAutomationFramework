Feature: SendMeme


@sanity
Scenario: SendMeme
	Given I launch the application
	And I choose Sign in with Email
	When I enter the username and password as
		| Username             | Password   |
		| testuser19@gmail.com | Parola1377 |
	And I click the Login Button
	Then I see the homepage
	When I click the SEND MEME button
	And I add a title and a photo from gallery
	And I click the POST button
	Then the number of posts in Database Table Posts is incremented
