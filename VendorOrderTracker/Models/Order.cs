using System;

namespace VendorOrderTracker.Models
{
  public class Order
  {
    private static List<Order> _instances = new List<Order> { };
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public DateTime Date { get; set; }

    // These aren't required so I'd start without them and add later if you decide you want them
    // public int VendorId { get; set; }
    // public Vendor Vendor { get; set; }

    // create constructor
    // create ClearAll() method
    // create GetAll() method
    // create Find() method
    // Be sure to create tests for each of the above
  }
}
