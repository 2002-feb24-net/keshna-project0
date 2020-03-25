using CupCakeData.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CupCakeData
{
   
        public class OrdersByLocationDB
        {
            public void GetOrdersByLocationDB(int locationID)
            {
            //string connectionString = SecretConfiguration.ConnectionString;

            DbContextOptions<CupCakeShopContext> options = new DbContextOptionsBuilder<CupCakeShopContext>()
         .UseSqlServer(secret.ConnectionString).Options;
             var context = new CupCakeShopContext(options);
            var context2 = new CupCakeShopContext(options);
            var context3 = new CupCakeShopContext(options);

            int count = 0;

                foreach (Orders order in context.Orders)
                {
                    var product = context2.Product.FirstOrDefault(p => p.ProductId == order.ProductId);
                    var location = context3.Location.FirstOrDefault(p => p.LocationId == order.LocationId);

                    if (order.LocationId == locationID)
                    {
                        count++;
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine($"| LocationID: {order.LocationId} | Location: {location.City} | Product: {product.Pname} | Quantity: {order.Quantity} | Date: {order.OrderTime} |");
                        Console.WriteLine("------------------------------------------------------------------------------------------");
                        Console.WriteLine("\nPress a key to continue");
                        Console.ReadKey();
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine("\nNo Orders at this Location");
                    Console.WriteLine("\nPress a key to continue");
                    Console.ReadKey();
                }
            }
        }
    
}
