using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;


namespace VendorOrderTracker.Controllers
{
  public class OrderController : Controller
  {

    public ActionResult Index()
    {
      List<Order> orders = Order.GetAll();
      return View();
    }

    //GET: Order/Details/5
    public ActionResult Details(int id)
    {
      Order order = Order.Find(id);
      return View(order);
    }

    //GET: Order/Create
    public ActionResult Create(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);

      return View();
    }


    public ActionResult Create()
    {
      return View();
    }

    //GET: Order/Edit/5
     public ActionResult Edit(int id)
    {
      return View();
    }

    //POST: Order/Edit/5
     public ActionResult Edit(int id, Order order)
    {
      return View();
    }

    //GET: Order/Delete/5
     public ActionResult Delete(int id)
    {
      return View();
    }

    public ActionResult DeleteConfirmed(int id)
    {
      return RedirectToAction("Index");
    }
  }
}
