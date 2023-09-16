using Microsoft.Playwright;
using QuintExercise.Drivers;

namespace QuintExercise.Pages
{
    public class HomePage
    {
        DriverHelpers _driverHelpers;
        public HomePage(DriverHelpers driverHelpers)
        {
            _driverHelpers = driverHelpers;
        }

        ILocator loanamount => _driverHelpers.page.GetByPlaceholder("£1,000 to £50,000");
        ILocator continuebtn => _driverHelpers.page.GetByRole(AriaRole.Button, new() { Name = "Continue" });




        public async Task EnterLoanAmount(string amount)
        {
            await loanamount.FillAsync(amount);
            await continuebtn.ClickAsync();
        }
    }
}
