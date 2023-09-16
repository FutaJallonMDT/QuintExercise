using Microsoft.Playwright;
using QuintExercise.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuintExercise.Pages
{
    public  class TitlePage
    {
        DriverHelpers _driverHelpers;
        public TitlePage(DriverHelpers driverHelpers)
        {
            _driverHelpers= driverHelpers;
        }

        ILocator Mister => _driverHelpers.page.GetByRole(AriaRole.Button, new() { Name = "Mr", Exact = true });

        public async Task ClickMr()
        {
            await Mister.ClickAsync();
        }
    }
}
