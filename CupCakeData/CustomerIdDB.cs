using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CupCakeData.Entities;
using Microsoft.EntityFrameworkCore;

namespace CupCakeData
{
    public class CustomerIdDB
    {
        public int GetCustomerIdDB(string firstName, string lastName)
        {
            //string connectionString = SecretConfiguration.ConnectionString;

            DbContextOptions<CupCakeShopContext> options = new DbContextOptionsBuilder<CupCakeShopContext>()
                .UseSqlServer(secret.ConnectionString).Options;
            var context = new CupCakeShopContext(options);

            var foundName = context.Customer.FirstOrDefault(p => p.FirstName == firstName && p.LastName == lastName);

            if (foundName is null)
            {
                Console.WriteLine("No Record Found");
                return 0;
            }
            else
                return foundName.CustomerId;
        }
    }
}
