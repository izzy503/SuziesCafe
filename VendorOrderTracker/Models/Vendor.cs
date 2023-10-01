using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    public static List<Vendor> _instances = new List<Vendor> { };
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Order> Orders { get; set; } = new List<Order>();

    // create constructor
    // create ClearAll() method
    // create GetAll() method
    // create Find() method
    // create AddOrder() method
    // Be sure to create tests for each of the above
  }
}
