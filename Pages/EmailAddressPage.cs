using Microsoft.Playwright;
using QuintExercise.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuintExercise.Pages
{
    public class EmailAddressPage
    {
        DriverHelpers _driverHelpers;
        public EmailAddressPage(DriverHelpers driverHelpers)
        {
            _driverHelpers = driverHelpers;
        }

        ILocator EmailAddy => _driverHelpers.page.Locator("#emailAddress");

        ILocator CONT3 => _driverHelpers.page.GetByRole(AriaRole.Button, new() { Name = "Continue" });

        public async Task EnterEmailAddyDetails(string email)
        {
            await EmailAddy.FillAsync(email);
            await CONT3.ClickAsync();
        }
    }
}
