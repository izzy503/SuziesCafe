// VendorOrderTracker.Tests/ModelTests/VendorTests.cs
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Tests.ModelTests
{
    [TestClass]
    public class VendorTests
    {
        [TestMethod]
        public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
        {
            // Arrange, Act
            Vendor newVendor = new Vendor();

            // Assert
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }

        // Add more test methods for Vendor class as needed.
    }
}
