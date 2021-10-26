using System;
using System.Collections.Generic;

#nullable disable

namespace StoreDL.Entities
{
    public partial class StoreFront
    {
        public int? StoreNumber { get; set; }
        public string Address { get; set; }
        public string Product { get; set; }
    }
}
