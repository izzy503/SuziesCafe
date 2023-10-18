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

    [HttpPost("/vendors")]
    public ActionResult Create(string name, string description)
    {  
      Vendor newVendor = new Vendor(name, description);

      return RedirectToAction("Index");
    }

    [HttpGet("vendors/create")]
    public ActionResult Create()
    {
      return View();
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Details(int id)
    {
      Vendor vendor = Vendor.Find(id);
      return View(vendor);
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
