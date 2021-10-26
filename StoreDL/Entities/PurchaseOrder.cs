using System;
using System.Collections.Generic;

#nullable disable

namespace StoreDL.Entities
{
    public partial class PurchaseOrder
    {
        public int? OrderId { get; set; }
        public DateTime? OrderDate { get; set; }
        public string OrderLocation { get; set; }
        public string ItemName { get; set; }
        public int? ItemQuantity { get; set; }
        public decimal? TotalPrice { get; set; }
    }
}
