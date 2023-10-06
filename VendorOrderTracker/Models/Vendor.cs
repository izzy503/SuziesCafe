using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
    public class Vendor
    {
        public static List<Vendor> _instances = new List<Vendor>();

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();

        // Constructor
        public Vendor(string name, string description)
        {
            Name = name;
            Description = description;
        }

        // Method to clear all vendors
        public static void ClearAll()
        {
            _instances.Clear();
        }

        // Method to get all vendors
        public static List<Vendor> GetAll()
        {
            return _instances;
        }

        // Method to find a vendor by Id
        public static Vendor Find(int id)
        {
            return _instances.Find(vendor => vendor.Id == id);
        }

        // Method to add an order to a vendor's list of orders
        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }
    }
}
