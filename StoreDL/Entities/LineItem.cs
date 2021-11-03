using System;
using System.Collections.Generic;

#nullable disable

namespace StoreDL.Entities
{
    public partial class LineItem
    {
        public int ItemId { get; set; }
        public int? Inventory { get; set; }

        public virtual Product Item { get; set; }
    }
}
