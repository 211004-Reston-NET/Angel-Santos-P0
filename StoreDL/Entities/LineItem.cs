using System;
using System.Collections.Generic;

#nullable disable

namespace StoreDL.Entities
{
    public partial class LineItem
    {
        public int? ItemId { get; set; }
        public string ItemName { get; set; }
        public int? ItemQuantity { get; set; }
    }
}
