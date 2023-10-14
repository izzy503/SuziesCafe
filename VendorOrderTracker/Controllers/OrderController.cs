using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VendorOrderTracker.Models;
using VendorOrderTracker.ViewModels;

namespace VendorOrderTracker.Controllers
{
  public class OrderController : Controller
  {
    // database context (dependency injection) should be injected here

    // GET: Order
    public IActionResult Index()
    {
      List<Order> orders = _orderRepository.GetAllOrders();
      return View(orders);
    }

    // GET: Order/Details/5
    public IActionResult Details(int id)
    {
      Order order = _orderRepository.GetOrderById(id);
      if (order == null)
      {
        return NotFound();
      }
      return View(order);
    }

    // GET: Order/Create
    public IActionResult Create(int vendorId)
    {
      Vendor vendor = _vendorRepository.GetVendorById(vendorId);
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

    // POST: Order/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(OrderViewModel orderViewModel)
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

        _orderRepository.AddOrder(newOrder);
        return RedirectToAction("Index");
      }
      return View(orderViewModel);
    }

    // GET: Order/Edit/5
    public IActionResult Edit(int id)
    {
      Order order = _orderRepository.GetOrderById(id);
      if (order == null)
      {
        return NotFound();
      }
      return View(order);
    }

    // POST: Order/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(int id, Order order)
    {
      if (id != order.Id)
      {
        return NotFound();
      }

      if (ModelState.IsValid)
      {
        _orderRepository.UpdateOrder(order);
        return RedirectToAction("Index");
      }
      return View(order);
    }

    // GET: Order/Delete/5
    public IActionResult Delete(int id)
    {
      Order order = _orderRepository.GetOrderById(id);
      if (order == null)
      {
        return NotFound();
      }
      return View(order);
    }

    // POST: Order/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
      Order order = _orderRepository.GetOrderById(id);
      if (order != null)
      {
        _orderRepository.DeleteOrder(order);
      }
      return RedirectToAction("Index");
    }
  }
}
