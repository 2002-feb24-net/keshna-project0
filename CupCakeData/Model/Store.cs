using System;
using System.Collections.Generic;

namespace CupCake.Model
{
    public partial class Store
    {
        public int LocationId { get; set; }
        public int ProductId { get; set; }
        public int ItemInStore { get; set; }

        public virtual Location Location { get; set; }
        public virtual Product Product { get; set; }
    }
}
