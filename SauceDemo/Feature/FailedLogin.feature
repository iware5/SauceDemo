Feature: FailedLogin
	As a customer with incorrect login details
	I must not be able to login 

@mytag
Scenario: Failed Login
	Given that I navigate to "https://www.saucedemo.com/"
	And I enter the incorrect username "locked_out_user"
	And I enter the password "secret_sauce"
	When I click the login button
	Then I should see an error message that says "Epic sadface: Sorry, this user has been locked out."