using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;


namespace VendorOrderTracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{Id}/orders/new")]
    public ActionResult Create(int Id)
    {
      Vendor vendor = Vendor.Find(Id);
      return View(vendor);
    }
  }
}
