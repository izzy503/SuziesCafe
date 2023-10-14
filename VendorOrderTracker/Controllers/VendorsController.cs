using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;
using VendorOrderTracker.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace VendorOrderTracker.Controllers
{
  public class VendorsController : Controller
  {
    private static List<Vendor> _vendors = new List<Vendor>();

    // ... Existing code ...

    // GET: Vendors/Details/5
    public IActionResult Details(int id)
    {
      Vendor vendor = _vendors.FirstOrDefault(v => v.Id == id);
      if (vendor == null)
      {
        return NotFound();
      }

      // Fetch orders for the selected vendor
      List<Order> vendorOrders = GetVendorOrders(vendor.Id);

      var vendorDetailsViewModel = new VendorDetailsViewModel
      {
        Vendor = vendor,
        Orders = vendorOrders
      };

      return View(vendorDetailsViewModel);
    }

    // GET: Vendors/CreateOrder/5
    public IActionResult CreateOrder(int id)
    {
      Vendor vendor = _vendors.FirstOrDefault(v => v.Id == id);
      if (vendor == null)
      {
        return NotFound();
      }

      var orderViewModel = new OrderViewModel
      {
        VendorId = vendor.Id,
        VendorName = vendor.Name,
        OrderDate = DateTime.Today
      };

      return View(orderViewModel);
    }

    // POST: Vendors/CreateOrder/5
    [HttpPost]
    public IActionResult CreateOrder(OrderViewModel orderViewModel)
    {
      if (ModelState.IsValid)
      {
        Order newOrder = new Order
        {
          VendorId = orderViewModel.VendorId,
          Title = orderViewModel.Title,
          Description = orderViewModel.Description,
          Price = orderViewModel.Price,
          Date = orderViewModel.OrderDate
        };



        return RedirectToAction("Details", new { id = orderViewModel.VendorId });
      }

      return View(orderViewModel);
    }

    // Additional actions for managing orders, editing vendors, etc.

    // Helper method to get orders for a specific vendor
    private List<Order> GetVendorOrders(int vendorId)
    {
      // Replace with actual logic to fetch orders from your data source
      // Example: return _orderRepository.GetOrdersForVendor(vendorId);
    }
  }
}
