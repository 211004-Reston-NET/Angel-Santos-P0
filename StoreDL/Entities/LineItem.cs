using System;
using System.Collections.Generic;

#nullable disable

namespace StoreDL.Entities
{
    public partial class LineItem
    {
        public int ProductId { get; set; }
        public string ItemName { get; set; }
        public int? LocationId { get; set; }
        public int? Inventory { get; set; }
        public decimal? Price { get; set; }

        public virtual StoreFront Location { get; set; }
        public virtual Product Product { get; set; }
    }
}
