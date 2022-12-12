using DapoProject.PageObject;
using System;
using TechTalk.SpecFlow;

namespace DapoProject.StepDefinition
{
    [Binding]
    public class FacebookMarketPlaceRegistrationSteps
    {
        RegistrationPage registrationPage;

        public FacebookMarketPlaceRegistrationSteps()
        {
            registrationPage = new RegistrationPage();
        }


        [Given(@"I Navigate to the Website")]
        public void GivenINavigateToTheWebsite()
        {
            registrationPage.NavigateToWebsite();
        }

        [Given(@"I click on Sign Up")]
        public void GivenIClickOnSignUp()
        {
            registrationPage.ClickOnSignup();
        }

        [Given(@"I type in Username")]
        public void GivenITypeInUsername()
        {
            registrationPage.TypeInUsername();
        }


        [Given(@"I type in Email")]
        public void GivenITypeInEmail()
        {
            registrationPage.TypeInEmail();
        }


        [Given(@"I typed in Password")]
        public void GivenITypedInPassword()
        {
            registrationPage.TypeInPassword();
        }

        [When(@"the Sign Up Button is clicked")]
        public void WhenTheSignUpButtonIsClicked()
        {
            registrationPage.ClickOnSignUpButton();
        }

        [Then(@"I should be able to sign up successfully")]
        public void ThenIShouldBeAbleToSignUpSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }



    }
}
