using System;
using System.Collections.Generic;

namespace CupCake.Model
{
    public partial class Product
    {
        public Product()
        {
            OrderProduct = new HashSet<OrderProduct>();
            Store = new HashSet<Store>();
        }

        public int Id { get; set; }
        public string Pname { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<OrderProduct> OrderProduct { get; set; }
        public virtual ICollection<Store> Store { get; set; }
    }
}
