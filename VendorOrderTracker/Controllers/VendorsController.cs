using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System.Linq;

namespace VendorOrderTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> vendorList = Vendor.GetAll();
      return View(vendorList);
    }
    public ActionResult Details(int id)
    {  
      // List<Order> vendorOrders = GetVendorOrders(vendor.Id);

      return View();
    }

    [HttpGet("vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    // GET: Vendors/CreateOrder/5
    public ActionResult CreateOrder(int id)
    {  
      return View();
    }

    // POST: Vendors/CreateOrder/5
    [HttpPost]
    public ActionResult CreateOrder()
    {
      return View();
    }
  }
}
