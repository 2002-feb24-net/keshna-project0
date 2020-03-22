using System;
using System.Collections.Generic;

namespace CupCake
{
    class Orders
    {

        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int StoreId { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime Time { get; set; }
    }
}
