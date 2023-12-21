Feature: Checkout Successfully
	In order to check out successfully
	A customer needs to log in and add item(s) to the basket

@mytag
Scenario: Succcessful Checkout
	Given that I navigate to "https://www.saucedemo.com/"
	And I enter the username "standard_user"
	And I enter the password "secret_sauce"
	And I click the login button
	And I add the first item to cart
	And I add the second item to cart
	And I click on basket icon
	And I click on checkout button
	And I enter my first name "Akindele"
	And I enter my second name "Abioye"
	And I enter my postal code "HD4 6DL"
	And I click continue button
	When I click the finish button
	Then I should see a successful message that says "Checkout: Complete!"