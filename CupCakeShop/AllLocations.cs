using CupCakeData;
using System;
using System.Collections.Generic;
using System.Text;

namespace CupCakeShop
{
    public class AllLocations
    {
        public void GetAllLocations()
        {
            var allLocations = new AllLocationsDB();
            allLocations.GetAllLocationsDB();
        }
    }
}
