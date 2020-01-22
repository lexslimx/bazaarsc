using System.Collections.Generic;

namespace bazaarcs.api.Model
{
    public class Order
    {
        public Order()
        {
            OrderItems = new HashSet<Listing>();
        }
        public string Id { get; set; }
        public string OrderId { get; set; }
        public ICollection<Listing> OrderItems { get; set; }        
    }
}