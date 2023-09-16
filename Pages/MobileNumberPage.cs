using Microsoft.Playwright;
using QuintExercise.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuintExercise.Pages
{
    public class MobileNumberPage
    {
        DriverHelpers _driverHelpers;
        public MobileNumberPage(DriverHelpers driverHelpers)
        {
            _driverHelpers = driverHelpers;
        }

        ILocator MobNO => _driverHelpers.page.Locator("#mobileNumber");
        ILocator CONT4 => _driverHelpers.page.GetByRole(AriaRole.Button, new() { Name = "Continue" });

        ILocator MarStatus => _driverHelpers.page.GetByRole(AriaRole.Heading, new() { Name = "What’s your marital status?" });

        public async Task EnterMobNumber(string MobileNo)
        {
           await MobNO.FillAsync(MobileNo);
            await CONT4.ClickAsync();
        }
    }
}
