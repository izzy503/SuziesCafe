using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;
using System.Collections.Generic;

namespace VendorOrderTracker.Controllers
{
  public class VendorsController : Controller
  {

    [HttpGet("vendors")]
    public IActionResult Index()
    {
      // Display a list of vendors
      return View();
    }

    [HttpGet("vendors/new")]
    public IActionResult Create()
    {
      // Display the form to create a new vendor
      return View();
    }

    [HttpPost("vendors")]
    public IActionResult Create(Vendor vendor)
    {
      // Create a new vendor and add it to the list
      // Add(vendor);
      return RedirectToAction("Index");
    }

    // Add actions for displaying vendor details, creating orders, and managing orders.
  }
}
