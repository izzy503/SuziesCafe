using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Tests.ModelTests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      // Arrange, Act
      Order newOrder = new Order();

      // Assert
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }


  }
}
