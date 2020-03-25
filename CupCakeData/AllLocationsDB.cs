using CupCakeData.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CupCakeData
{
    public class AllLocationsDB
    {
        public void GetAllLocationsDB()
        {
            

            DbContextOptions<CupCakeShopContext> options = new DbContextOptionsBuilder<CupCakeShopContext>()
                .UseSqlServer(secret.ConnectionString).Options;
             var context = new CupCakeShopContext(options);

            foreach (Location location in context.Location)
            {
                
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine($"| LocationId: {location.LocationId} | City: {location.City} |");
                Console.WriteLine("----------------------------------------------");
            }
        }
    }
}
