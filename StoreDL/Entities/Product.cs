using System;
using System.Collections.Generic;

#nullable disable

namespace StoreDL.Entities
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ItemName { get; set; }
        public string Category { get; set; }
        public decimal? Price { get; set; }
        public string Description { get; set; }
        public int? StoreLocation { get; set; }

        public virtual LineItem LineItem { get; set; }
    }
}
