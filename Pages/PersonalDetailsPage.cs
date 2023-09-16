using Microsoft.Playwright;
using QuintExercise.Drivers;

namespace QuintExercise.Pages
{
    
    public class PersonalDetailsPage
    { 
        DriverHelpers _driverHelpers;
        public PersonalDetailsPage(DriverHelpers driverHelpers)
        {
            _driverHelpers= driverHelpers;
        }

        ILocator FirsName => _driverHelpers.page.Locator("#firstName");
        ILocator LastName => _driverHelpers.page.Locator("#lastName");

        ILocator ClickCONTBTN => _driverHelpers.page.GetByRole(AriaRole.Button, new() { Name = "Continue" });

        public async Task EnterPersonalDetails(string firstName, string lastName)
        {
            await FirsName.FillAsync(firstName);
            await LastName.FillAsync(lastName);
            await ClickCONTBTN.ClickAsync();
        }

    }

    
}
