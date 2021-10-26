using System;
using System.Collections.Generic;

#nullable disable

namespace StoreDL.Entities
{
    public partial class StoreProduct
    {
        public int? ItemId { get; set; }
        public string ItemCategory { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public int? ItemQuantity { get; set; }
        public decimal? Price { get; set; }
    }
}
