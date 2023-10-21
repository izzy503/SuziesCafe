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


    [HttpGet("vendors/create")]
    public ActionResult Create()
    {
      return View();
    }


    [HttpPost("/vendors")]
    public ActionResult Create(string name, string description)
    {
      Vendor newVendor = new Vendor(name, description);

      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}/orders")]
    public ActionResult Details(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor vendor = Vendor.Find(id);
      List<Order> orders = vendor.OrdersList;
      model.Add("vendor", vendor);
      model.Add("orders", orders);
      return View(model);
    }

    [HttpPost("/vendors/{id}/orders")]
    public ActionResult Create(int Id, string orderTitle, string orderDesc, decimal orderPrice)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor vendor = Vendor.Find(Id);
      Order newOrder = new Order(orderTitle, orderDesc, orderPrice);

      vendor.AddOrder(newOrder);
      List<Order> orders = vendor.OrdersList;
      model.Add("orders", orders);
      model.Add("vendor", vendor);
      return View("Details", model);
    }
  }
}
