using System;
using System.Collections.Generic;

#nullable disable

namespace StoreDL.Entities
{
    public partial class LineItem
    {
        public int OrderId { get; set; }
        public int? Inventory { get; set; }
    }
}
