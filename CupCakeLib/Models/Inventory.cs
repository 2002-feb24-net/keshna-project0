using System;
using System.Collections.Generic;
using System.Text;

namespace CupCake
{
    // optional. Dont think inventory is required
    class Inventory
    {
        public int InventoryId { get; set; }
        public int StoreId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
