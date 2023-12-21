using OpenQA.Selenium;
using SauceDemo.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SauceDemo.PageObject
{
    class SauceDemoPage
    {

        public SauceDemoPage()
        {
            driver = Hooks.driver;
        }

        IWebDriver driver;

        IWebElement username => driver.FindElement(By.XPath("//input[@id='user-name']"));
        IWebElement password => driver.FindElement(By.XPath("//input[@id='password']"));
        IWebElement loginbutton => driver.FindElement(By.XPath("//input[@id='login-button']"));
        IWebElement firstitem => driver.FindElement(By.XPath("//button[@id='add-to-cart-sauce-labs-backpack']"));
        IWebElement seconditem => driver.FindElement(By.XPath("//button[@id='add-to-cart-sauce-labs-bike-light']"));
        IWebElement basket => driver.FindElement(By.XPath("//span[@class='shopping_cart_badge']"));
        IWebElement checkout => driver.FindElement(By.XPath("//button[@id='checkout']"));
        IWebElement firstname => driver.FindElement(By.XPath("//input[@id='first-name']"));
        IWebElement lastname => driver.FindElement(By.XPath("//input[@id='last-name']"));
        IWebElement postalcode => driver.FindElement(By.XPath("//input[@id='postal-code']"));
        IWebElement continuebutton => driver.FindElement(By.XPath("//input[@id='continue']"));
        IWebElement finishbutton => driver.FindElement(By.XPath("//button[@id='finish']"));
        IWebElement ordersuccessful => driver.FindElement(By.XPath("//span[@class='title']"));
        IWebElement loginerror => driver.FindElement(By.XPath("//h3[@data-test='error']"));

        public void NavigateToUrl(String Url)
        {
            driver.Navigate().GoToUrl(Url);
        }

        public void Username(String Username)
        {
            username.SendKeys(Username);
        }

        public void Password(String Password)
        {
            password.SendKeys(Password);
        }

        public void Login()
        {
            loginbutton.Click();
        }

        public void AddFirstItem()
        {
            firstitem.Click();
        }

        public void AddSecondItem()
        {
            seconditem.Click();
        }

        public void BasketIcon()
        {
            basket.Click();
        }

        public void Checkout()
        {
            checkout.Click();
        }

        public void FirstName(String First)
        {
            firstname.SendKeys(First);
        }

        public void LastName(String Last)
        {
            lastname.SendKeys(Last);
        }

        public void PostalCode(String Postcode)
        {
            postalcode.SendKeys(Postcode);
        }

        public void Continue()
        {
            continuebutton.Click();
        }

        public void FinishCheckout()
        {
            finishbutton.Click();
        }

        public bool CheckoutComplete()
        {
            return ordersuccessful.Displayed;
        }

        public bool LoginErrorMessage()
        {
            return loginerror.Displayed;
        }
    }
}
