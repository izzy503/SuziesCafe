using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Models
{
  public class Order
  {
    private static List<Order> _instances = new List<Order>();

    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }

    public Order()
    {

    }

    public Order(string title, string description, decimal price)
    {
      Title = title;
      Description = description;
      Price = price;
    }
  }
}
