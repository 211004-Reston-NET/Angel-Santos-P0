using System;
using System.Collections.Generic;

#nullable disable

namespace StoreDL.Entities
{
    public partial class PurchaseOrder
    {
        public int? OrderId { get; set; }
        public int? LocationId { get; set; }
        public string ItemName { get; set; }
        public decimal? TotalPrice { get; set; }
    }
}
