using Microsoft.Playwright;
using QuintExercise.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuintExercise.Pages
{
    public class Purpose
        
    {
        DriverHelpers _driverHelpers;

        public Purpose(DriverHelpers driverHelpers)
        {
            _driverHelpers = driverHelpers;
        }

        ILocator CarVehicle => _driverHelpers.page.GetByRole(AriaRole.Button, new() { Name = "Car / Vehicle" });

        public async Task ClickCarVehicle() 
        {
           await CarVehicle.ClickAsync();
        }
    }
}
