using System;
using System.Collections.Generic;

#nullable disable

namespace StoreDL.Entities
{
    public partial class StoreFront
    {
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
