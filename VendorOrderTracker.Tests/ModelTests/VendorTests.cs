using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System;
using System.Collections.Generic;

namespace VendorOrderTracker.Tests.ModelTests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      // Arrange, Act
      Vendor newVendor = new Vendor("Vendor Name", "Vendor Description");

      // Assert
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void Constructor_SetsProperties()
    {
      // Arrange
      string name = "Vendor Name";
      string description = "Vendor Description";

      // Act
      Vendor vendor = new Vendor(name, description);

      // Assert
      Assert.AreEqual(name, vendor.Name);
      Assert.AreEqual(description, vendor.Description);
    }

    [TestMethod]
    public void ClearAll_ClearsVendors()
    {
      // Arrange
      Vendor.ClearAll();

      // Act
      List<Vendor> result = Vendor.GetAll();

      // Assert
      CollectionAssert.AreEqual(new List<Vendor>(), result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendors()
    {
      // Arrange
      Vendor.ClearAll();
      Vendor vendor1 = new Vendor("Vendor 1", "Description 1");
      Vendor vendor2 = new Vendor("Vendor 2", "Description 2");

      // Act
      List<Vendor> result = Vendor.GetAll();

      // Assert
      CollectionAssert.AreEqual(new List<Vendor> { vendor1, vendor2 }, result);
    }

    [TestMethod]
    public void Find_ReturnsVendorById()
    {
      // Arrange
      Vendor.ClearAll();
      Vendor vendor1 = new Vendor("Vendor 1", "Description 1");
      Vendor vendor2 = new Vendor("Vendor 2", "Description 2");

      // Act
      Vendor result = Vendor.Find(vendor2.Id);

      // Assert
      Assert.AreEqual(vendor2, result);
    }

    [TestMethod]
    public void AddOrder_AddsOrderToVendor()
    {
      // Arrange
      Vendor.ClearAll();
      Vendor vendor = new Vendor("Vendor 1", "Description 1");
      Order order = new Order("Order 1", "Order Description", 10.99m, "11/4/2023");

      // Act
      vendor.AddOrder(order);

      // Assert
      Assert.AreEqual(1, vendor.Orders.Count);
      Assert.AreEqual(order, vendor.Orders[0]);
    }
  }
}
