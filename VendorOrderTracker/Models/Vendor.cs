using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
    public class Vendor
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Order> OrdersList { get; set; }
        public static List<Vendor> _instances = new List<Vendor>();

        public Vendor()
        {

        }
        // Constructor
        public Vendor(string name, string description)
        {
            Name = name;
            Description = description;
            OrdersList = new List<Order> { };
            _instances.Add(this);
            Id = _instances.Count;
        }

        // Method to add an order to a vendor's list of orders
        public void AddOrder(Order order)
        {
            OrdersList.Add(order);
            order.Id = OrdersList.Count;
        }

        public Order GetOrderById(int oID)
        {
            return OrdersList[oID - 1];
        }

        // Method to find a vendor by Id
        public static Vendor Find(int id)
        {

            return _instances[id - 1];
        }

        public static List<Vendor> GetAll()
        {
            return _instances;
        }

    }
}
