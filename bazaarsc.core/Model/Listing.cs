using System;
using System.Collections.Generic;

namespace bazaarcs.api.Model
{
    public class Listing{
        public Listing()
        {
            Tags = new HashSet<Tag>();
        }
        public int ListingId { get; set; }
        public string ListingName { get; set; }
        public string ListingCode { get; set; }            
        public ListingCondition Condition { get; set; }
        public float Price { get; set; }
        public DateTime ListingDate { get; set; }
        public virtual ListingCategory ListingCategory { get; set; }
        public int ListingCategoryId { get; set; }
        public string imageUrl { get; set; }
        public string AspNetUserId { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }
}