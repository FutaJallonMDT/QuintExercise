using Microsoft.Playwright;
using QuintExercise.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuintExercise.Pages
{
    public class DOBPage
    {
        DriverHelpers _driverHelpers;
        public DOBPage(DriverHelpers driverHelpers)
        {
            _driverHelpers = driverHelpers;
        }

        ILocator dob => _driverHelpers.page.Locator("#dateOfBirth");
        ILocator CONT2 => _driverHelpers.page.GetByRole(AriaRole.Button, new() { Name = "Continue" });

        public async Task EnterDOBDetails(string DOB)
        {
            await dob.FillAsync(DOB);
            await CONT2.ClickAsync();
        }
    }
}
