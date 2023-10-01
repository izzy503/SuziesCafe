using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;
using System.Collections.Generic;

namespace VendorOrderTracker.Controllers
{
  public class VendorsController : Controller
  {
    private static List<Vendor> _vendors = new List<Vendor>();

    public IActionResult Index()
    {
      // Display a list of vendors
      return View(_vendors);
    }

    [HttpGet]
    public IActionResult Create()
    {
      // Display the form to create a new vendor
      return View();
    }

    [HttpPost]
    public IActionResult Create(Vendor vendor)
    {
      // Create a new vendor and add it to the list
      _vendors.Add(vendor);
      return RedirectToAction("Index");
    }

    // Add actions for displaying vendor details, creating orders, and managing orders.
  }
}
