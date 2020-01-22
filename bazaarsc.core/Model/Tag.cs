using System;
using System.Collections.Generic;
using System.Text;

namespace bazaarcs.api.Model
{
    public class Tag
    {
        public int TagId { get; set; }
        public string Name { get; set; }
        public int ListingId { get; set; }
        public virtual Listing Listing { get; set; }
    }
}
