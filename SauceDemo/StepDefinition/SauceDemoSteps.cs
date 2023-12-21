using NUnit.Framework;
using SauceDemo.PageObject;
using System;
using TechTalk.SpecFlow;

namespace SauceDemo.StepDefinition
{
    [Binding]
    public class SauceDemoSteps
    {
        SauceDemoPage sauceDemoPage;

        public SauceDemoSteps()
        {
            sauceDemoPage = new SauceDemoPage();
        }

        [Given(@"that I navigate to ""(.*)""")]
        public void GivenThatINavigateTo(string Url)
        {
            sauceDemoPage.NavigateToUrl(Url);
        }
        
        [Given(@"I enter the username ""(.*)""")]
        public void GivenIEnterTheUsername(string Username)
        {
            sauceDemoPage.Username(Username);
        }
        
        [Given(@"I enter the password ""(.*)""")]
        public void GivenIEnterThePassword(string Password)
        {
            sauceDemoPage.Password(Password);
        }

        [Given(@"I click the login button")]
        public void GivenIClickTheLoginButton()
        {
            sauceDemoPage.Login();
        }
        
        [Given(@"I add the first item to cart")]
        public void GivenIAddTheFirstItemToCart()
        {
            sauceDemoPage.AddFirstItem();
        }
        
        [Given(@"I add the second item to cart")]
        public void GivenIAddTheSecondItemToCart()
        {
            sauceDemoPage.AddSecondItem();
        }
        
        [Given(@"I click on basket icon")]
        public void GivenIClickOnBasketIcon()
        {
            sauceDemoPage.BasketIcon();
        }
        
        [Given(@"I click on checkout button")]
        public void GivenIClickOnCheckoutButton()
        {
            sauceDemoPage.Checkout();
        }
        
        [Given(@"I enter my first name ""(.*)""")]
        public void GivenIEnterMyFirstName(string First)
        {
            sauceDemoPage.FirstName(First);
        }
        
        [Given(@"I enter my second name ""(.*)""")]
        public void GivenIEnterMySecondName(string Last)
        {
            sauceDemoPage.LastName(Last);
        }
        
        [Given(@"I enter my postal code ""(.*)""")]
        public void GivenIEnterMyPostalCode(string Postcode)
        {
            sauceDemoPage.PostalCode(Postcode);
        }
        
        [Given(@"I click continue button")]
        public void GivenIClickContinueButton()
        {
            sauceDemoPage.Continue();
        }
        
        [When(@"I click the finish button")]
        public void WhenIClickTheFinishButton()
        {
            sauceDemoPage.FinishCheckout();
        }
        
        [Then(@"I should see a successful message that says ""(.*)""")]
        public void ThenIShouldSeeASuccessfulMessageThatSays(string Complete)
        {
            Assert.That(sauceDemoPage.CheckoutComplete);
        }

        [Given(@"I enter the incorrect username ""(.*)""")]
        public void GivenIEnterTheIncorrectUsername(string IncorrectUsername)
        {
            sauceDemoPage.Username(IncorrectUsername);
        }

        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            sauceDemoPage.Login();
        }

        [Then(@"I should see an error message that says ""(.*)""")]
        public void ThenIShouldSeeAnErrorMessageThatSays(string ErrorMessage)
        {
            Assert.That(sauceDemoPage.LoginErrorMessage);
        }





    }
}
