using Microsoft.Playwright;
using NUnit.Framework.Constraints;
using Playwright_BaseFramework.Support;
using TechTalk.SpecFlow;

namespace Playwright_BaseFramework.StepDefinitions
{
    [Binding]
    public sealed class SauceDemoStepDefinitions
    {
        private ScenarioContext scenarioContext;
        public PageObject pageObject;

        public SauceDemoStepDefinitions(PageObject pageObject, ScenarioContext scenarioContext)
        {
            this.pageObject = pageObject;
            this.scenarioContext = scenarioContext;
        }

        [Given(@"Login page is loaded")]
        public async Task GivenLoginPageIsLoaded()
        {
            try
            {
                await this.pageObject.Page.GotoAsync("https://www.saucedemo.com/", new()
                {
                    Timeout = 0 
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        [When(@"Enter username as (.*) in login page")]
        public async Task WhenEnterUsernameAsStandard_UserInLoginPage(string userName)
        {
            try
            {
                await this.pageObject.Page.Locator("[data-test=\"username\"]").ClickAsync();
                await this.pageObject.Page.Locator("[data-test=\"username\"]").FillAsync(userName);                
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [When(@"Enter password in login page")]
        public async Task WhenEnterPasswordInLoginPage()
        {
            try
            {
                await this.pageObject.Page.Locator("[data-test=\"password\"]").ClickAsync();
                await this.pageObject.Page.Locator("[data-test=\"password\"]").FillAsync("secret_sauce");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [When(@"Click submit button in login page")]
        public async Task WhenClickSubmitButtonInLoginPage()
        {
            try
            {
                await this.pageObject.Page.Locator("[data-test=\"login-button\"]").ClickAsync(new()
                {
                    Delay = 5_000
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [Then(@"Product page is loaded")]
        public async Task ThenProductPageIsLoaded()
        {
            try
            {
                await Assertions.Expect(this.pageObject.Page.Locator("[data-test=\"title\"]")).ToBeVisibleAsync(new()
                {
                    Timeout = 30_000,
                    Visible = true
                });
                await Assertions.Expect(this.pageObject.Page.Locator("[data-test=\"title\"]")).ToContainTextAsync("Products", new()
                {
                    Timeout = 10_000                    
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [When(@"Select following Backpack,Bolt T-Shirt,Bike Light in product page")]
        public async Task WhenSelectFollowingBackpackBoltT_ShirtBikeLightInProductPage()
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [When(@"Click on cart icon in product page")]
        public async Task WhenClickOnCartIconInProductPage()
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [Then(@"Cart page is loaded")]
        public async Task ThenCartPageIsLoaded()
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [When(@"Remove a Bolt T-Shirt from cart")]
        public async Task WhenRemoveABoltT_ShirtFromCart()
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [When(@"Click on checkout button in cart page")]
        public async Task WhenClickOnCheckoutButtonInCartPage()
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [Then(@"Checkout info page is loaded")]
        public async Task ThenCheckoutInfoPageIsLoaded()
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [When(@"Provide user information rohit and saraswat and (.*)")]
        public async Task WhenProvideUserInformationRohitAndSaraswatAnd(int p0)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [When(@"Click on continue button in checkout info page")]
        public async Task WhenClickOnContinueButtonInCheckoutInfoPage()
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [Then(@"Payment page is loaded")]
        public async Task ThenPaymentPageIsLoaded()
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [When(@"Click on finish button in payment page")]
        public async Task WhenClickOnFinishButtonInPaymentPage()
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [Then(@"Checkout complete page is loaded")]
        public async Task ThenCheckoutCompletePageIsLoaded()
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}