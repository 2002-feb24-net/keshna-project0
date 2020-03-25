using System;
using System.Collections.Generic;
using System.Text;
using CupCakeData;

namespace CupCakeShop
{
    public class AllProducts
    {
        public void GetAllProducts()
        {
            var displayAllProducts = new AllProductsDB();
            displayAllProducts.GetAllProducts();
        }
    }
}
