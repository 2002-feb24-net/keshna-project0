using System;
using System.Collections.Generic;

namespace CupCake.Model
{
    public partial class Location
    {
        public Location()
        {
            Orders = new HashSet<Orders>();
            Store = new HashSet<Store>();
        }

        public int Id { get; set; }
        public string Zipcode { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<Store> Store { get; set; }
    }
}
