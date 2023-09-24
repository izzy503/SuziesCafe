using System;

namespace VendorOrderTracker.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public int VendorId { get; set; }
        public Vendor Vendor { get; set; }
    }
}
