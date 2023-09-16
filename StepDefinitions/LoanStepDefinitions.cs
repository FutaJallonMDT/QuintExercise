using Microsoft.Playwright;
using NUnit.Framework;
using QuintExercise.Drivers;
using QuintExercise.Pages;
using System;
using System.Xml.Linq;
using TechTalk.SpecFlow;

namespace QuintExercise.StepDefinitions
{
    [Binding]
    public class LoanStepDefinitions
    {
        DriverHelpers _driverHelpers;
        HomePage homepage;
        Duration duration;
        Purpose purpose;
        TitlePage title;
        PersonalDetailsPage personalDetailsPage;
        DOBPage dobPage;
        EmailAddressPage emailAddressPage;
        MobileNumberPage mobileNoPage;
        public LoanStepDefinitions(DriverHelpers driverHelpers)
        {
            _driverHelpers= driverHelpers;
            homepage = new HomePage(_driverHelpers);
            duration = new Duration(_driverHelpers);
            purpose = new Purpose(_driverHelpers);
            title = new TitlePage(_driverHelpers);
            personalDetailsPage= new PersonalDetailsPage(_driverHelpers);
            dobPage = new DOBPage(_driverHelpers);
            emailAddressPage = new EmailAddressPage(_driverHelpers);
            mobileNoPage    = new MobileNumberPage(_driverHelpers);
        }

        [Given(@"user is on monevo page")]
        public async Task GivenUserIsOnMonevoPage()
        {
            bool confirmedUrl = _driverHelpers.page.Url.Contains("monevo");
            Assert.True(confirmedUrl);
        }

        [When(@"user enter loan amount '(.*)'")]
        public async Task WhenUserEnterLoanAmount(string amount)
        {
           await homepage.EnterLoanAmount(amount);
        }

        [When(@"user select duration '(.*)'")]
        public async Task WhenUserSelectDuration(string term)
        {
            await duration.ClickDuration(term);
        }

        [When(@"user select what to use the loan for")]
        public async Task WhenUserSelectWhatToUseTheLoanFor()
        {
            await purpose.ClickCarVehicle();
        }

        [When(@"user select title")]
        public async Task WhenUserSelectTitle()
        {
            await title.ClickMr();
        }

        [When(@"user enters firstname '([^']*)' and lastname '([^']*)'")]
        public async Task WhenUserEntersFirstnameAndLastname(string owen, string wdwWWRVDAD)
        {
            await personalDetailsPage.EnterPersonalDetails(owen, wdwWWRVDAD);
        }

        [When(@"user enter date of birth '([^']*)'")]
        public async Task WhenUserEnterDateOfBirth(string dob)
        {
           await dobPage.EnterDOBDetails(dob);
        }

        [When(@"user enter email '([^']*)'")]
        public async Task WhenUserEnterEmail(string email)
        {
           await emailAddressPage.EnterEmailAddyDetails(email);
        }

        [When(@"user enter phone number '([^']*)'")]
        public async Task WhenUserEnterPhoneNumber(string MobNo)
        {
           await mobileNoPage.EnterMobNumber(MobNo);
        }

        [Then(@"phone number passes form validation and whats your marital status is displayed")]
        public async Task ThenPhoneNumberPassesFormValidationAndWhatsYourMaritalStatusIsDisplayed()
        {
            //var whatsyourmaritalstatus =  _driverHelpers.page.GetByText("What’s your marital status?");
            //Assert.IsTrue(whatsyourmaritalstatus);
            //await Task.Delay(2000);
            await _driverHelpers.page.GetByText("What’s your marital status").WaitForAsync();
            var Maritalstatus = await _driverHelpers.page.GetByText("What’s your marital status").IsVisibleAsync();
            Assert.True(Maritalstatus);
        }

        [Then(@"error message is displayed")]
        public async Task ThenErrorMessageIsDisplayed()
        {
            await _driverHelpers.page.Locator("div[class='error']").WaitForAsync();
            var errorMsg = await _driverHelpers.page.Locator("div[class='error']").IsVisibleAsync();
            Assert.True(errorMsg);
        }

    }
}
