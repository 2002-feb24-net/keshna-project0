using System;
using System.Collections.Generic;
using System.Text;
using CupCakeLib;
using CupCakeData;
using CupCakeData.Model;
using CupCakeLib.Interface;
using CupCakeLib.Models;
using Microsoft.EntityFrameworkCore;

namespace CupCakeShop
{
    class Dependencies
    {
        public static IRepo CreateDataRepo()
        {
            var optionsBuilder = new DbContextOptionsBuilder<CupCakeShopContext>();
            optionsBuilder.UseSqlServer(secret.ConnectionString);

            var dbContext = new CupCakeShopContext(optionsBuilder.Options);
            return new DataRepo(dbContext);
        }
       
        
    }
}
