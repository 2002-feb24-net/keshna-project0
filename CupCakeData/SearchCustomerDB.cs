using CupCakeData.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CupCakeData
{
    public class SearchCustomerDB
    {
        public void SearchForCustomerDB(string firstName, string lastName)
        {
            // string connectionString = SecretConfiguration.ConnectionString;


            DbContextOptions<CupCakeShopContext> options = new DbContextOptionsBuilder<CupCakeShopContext>()
                .UseSqlServer(secret.ConnectionString).Options;
           var context = new CupCakeShopContext(options);
         

            var foundName = context.Customer.FirstOrDefault(p => p.FirstName == firstName && p.LastName == lastName);

            if (foundName is null)
            {
                Console.WriteLine("No Record Found");
                return;
            }
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"\n| CustomerId: {foundName.CustomerId} | CustomerName: {foundName.FirstName} {foundName.LastName} |");
            Console.WriteLine("----------------------------------------------");
        }
    }
}