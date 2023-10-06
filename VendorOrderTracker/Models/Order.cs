using System.Collections.Generic;
using System;
using System.Linq; // You need this using directive for FirstOrDefault

namespace VendorOrderTracker.Models
{
  public class Order
  {
    private static List<Order> _instances = new List<Order>();

    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public DateTime Date { get; set; }

    // Constructor
    public Order(string title, string description, decimal price, DateTime date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
    }

    // Method to clear all orders
    public static void ClearAll()
    {
      _instances.Clear();
    }

    // Method to get all orders
    public static List<Order> GetAll()
    {
      return _instances;
    }

    // Method to find an order by Id
    public static Order Find(int id)
    {
      return _instances.FirstOrDefault(order => order.Id == id);
    }
  }
}
