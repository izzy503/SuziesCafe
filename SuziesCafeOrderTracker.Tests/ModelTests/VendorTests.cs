using Microsoft.VisualStudio.TestTools.UnitTesting;
// VendorOrderTracker/Models/Vendor.cs
using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Order> Orders { get; set; } = new List<Order>();
  }
}
