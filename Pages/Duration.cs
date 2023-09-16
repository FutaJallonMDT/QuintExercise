using Microsoft.Playwright;
using QuintExercise.Drivers;

namespace QuintExercise.Pages
{
    public class Duration
    {
        DriverHelpers _driverHelpers;
        public Duration(DriverHelpers driverHelpers)
        {
            _driverHelpers = driverHelpers;
        }

        ILocator duration(string option) => _driverHelpers.page.GetByRole(AriaRole.Button, new() { Name = $"{option}" });




        public async Task ClickDuration(string option) => await duration(option).ClickAsync();
    }
}
