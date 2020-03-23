using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
//using NLog;
using CupCakeLib.Interface;
using CupCakeData.Model;
using CupCakeLib.Models;
using CupCakeData;
using CupCakeLib;

namespace CupCakeData
{
    /// <summary>
    /// A repository managing data access for restaurant objects and their review members,
    /// using Entity Framework.
    /// </summary>
    /// <remarks>
    /// This class ought to have better exception handling and logging.
    /// </remarks>
    public class DataRepo : IRepo, IDisposable

    {
        public static Customer CurrentCustomer;
  
        private bool DisposeVal = false;
        private readonly CupCakeShopContext Context;
        public DataRepo(CupCakeShopContext dbContext)
        {
            try
            {
                Context = dbContext;
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("This is cannot be null.", e);
            }
        }
            // private static readonly ILogger s_logger = LogManager.GetCurrentClassLogger();

            /// <summary>
            /// Initializes a new restaurant repository given a suitable restaurant data source.
            /// </summary>
            /// <param name="Context">The data source</param>
            public void SaveChanges()
        {
            Context.SaveChanges();
        }

        protected virtual void Dispose(bool dispose)
        {
            if (!DisposeVal)
            {
                if (dispose)
                {
                    Context.Dispose();
                }
                DisposeVal = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }

        /// <summary>
        /// Adds a customer to the database.
        /// </summary>
        /// <param name="AddCustomer">The customer to add to the database</param>
        public void AddCustomer(Customers AddCustomer)
        {
           

            Customer addCustomer = new Customer()
            {
                Cname = AddCustomer.CName,
                Phone = AddCustomer.Phone
            };
            Context.Customer.Add(addCustomer);
            Context.SaveChanges();
            
        }
        public void SearchCustomer(String name)
        {

            var Name = Context.Customer.FirstOrDefault(n => n.Cname == name);
            Console.WriteLine("Found " + name + " at: ");
            Console.WriteLine("ID: " + Name.Id + " Name: " + Name.Cname +  " Phone: " + Name.Phone);

        }
    }
}
