using System;
using CupCakeData.Entities;
using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CupCakeData
{
    public class NewOrderDB
    {
        public void PlaceNewOrderDB(int customerId, int cupId, int cupLocationId, int cupQuantId, decimal orderTotal)
        {
            
            DbContextOptions<CupCakeShopContext> options = new DbContextOptionsBuilder<CupCakeShopContext>()
             .UseSqlServer(secret.ConnectionString).Options;
            var context = new CupCakeShopContext(options);
            DateTime dateTime = new DateTime(2020, 03, 24);

            Orders newOrder = new Orders();

            newOrder.CustomerId = customerId;
            newOrder.ProductId = cupId;
            newOrder.LocationId = cupLocationId;
            newOrder.Quantity = cupQuantId;
            newOrder.OrderTotal = orderTotal;
            newOrder.OrderTime = dateTime;

            context.Orders.Add(newOrder);

            context.SaveChanges();
        }
    }
}
