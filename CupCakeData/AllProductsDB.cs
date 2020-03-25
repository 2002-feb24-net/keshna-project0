using System;
using CupCakeData.Entities;
using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CupCakeData
{
    public class AllProductsDB
    {
        public void GetAllProducts()
        {
            //string connectionString = SecretConfiguration.ConnectionString;

            DbContextOptions<CupCakeShopContext> options = new DbContextOptionsBuilder<CupCakeShopContext>()
                .UseSqlServer(secret.ConnectionString).Options;
             var context = new CupCakeShopContext(options);
            foreach (Product product in context.Product)
            {
                
                Console.WriteLine("-----------------------------------");
                Console.WriteLine($"| ProductId: {product.ProductId} | ProductName: {product.Pname} |");
                Console.WriteLine("-----------------------------------");
            }
        }
    }
}
