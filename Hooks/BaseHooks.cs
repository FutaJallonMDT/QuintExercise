using Microsoft.Playwright;
using QuintExercise.Drivers;
using QuintExercise.Support;

namespace QuintExercise.Hooks
{
    [Binding]
    public sealed class BaseHooks 
    {
        DriverHelpers _driverhelpers;
        public BaseHooks(DriverHelpers driverhelpers)
        {
            _driverhelpers = driverhelpers;
        }

        [BeforeScenario]
        public async Task BeforeScenarioWithTag()
        {
            _driverhelpers.playwright = Playwright.CreateAsync().Result;
            _driverhelpers.browser = await _driverhelpers.playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                 Headless = false,
                 SlowMo = 30,
                 Channel = "chrome"
            });
            _driverhelpers.page = _driverhelpers.browser.NewPageAsync(new BrowserNewPageOptions
            {
                 ViewportSize = new ViewportSize
                 {
                     Height = 1080,
                     Width = 1920
                 }
            }).Result;
            await _driverhelpers.page.GotoAsync(env.url);
        }

        [AfterScenario]
        public async Task AfterScenario()
        {
            await _driverhelpers.page.CloseAsync();
        }
    }
}