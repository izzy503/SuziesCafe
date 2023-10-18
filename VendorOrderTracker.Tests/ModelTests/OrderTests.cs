using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System;
using System.Collections.Generic;

namespace VendorOrderTracker.Tests.ModelTests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      // Arrange
      string title = "Test Order";
      string description = "Test Description";
      decimal price = 10.99m;
      string date = "11/4/2023";

      // Act
      Order testOrder = new Order(title, description, price, date);

      // Assert
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }

    [TestMethod]
    public void Constructor_SetsProperties()
    {
      // Arrange
      string title = "Test Order";
      string description = "Test Description";
      decimal price = 10.99m;
      string date = "11/4/2023";

      // Act
      Order testOrder = new Order(title, description, price, date);

      // Assert
      Assert.AreEqual(title, testOrder.Title);
      Assert.AreEqual(description, testOrder.Description);
      Assert.AreEqual(price, testOrder.Price);
      Assert.AreEqual(date, testOrder.Date);
    }

    [TestMethod]
    public void ClearAll_ClearsOrders()
    {
      // Arrange
      Order.ClearAll();

      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(new List<Order>(), result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllOrders()
    {
      // Arrange
      Order.ClearAll();
      Order order1 = new Order("Order 1", "Description 1", 10.99m, "11/4/2023");
      Order order2 = new Order("Order 2", "Description 2", 19.99m, "11/4/2023");

      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(new List<Order> { order1, order2 }, result);
    }

    [TestMethod]
    public void Find_ReturnsOrderById()
    {
      // Arrange
      Order.ClearAll();
      Order order1 = new Order("Order 1", "Description 1", 10.99m, "11/4/2023");
      Order order2 = new Order("Order 2", "Description 2", 19.99m, "11/4/2023");

      // Act
      Order result = Order.Find(order2.Id);

      // Assert
      Assert.AreEqual(order2, result);
    }
  }
}
