using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;
using System.Collections.Generic;

namespace VendorTracker.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendor")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetVendors();
      return View(allVendors);
    }
    [HttpGet("/vendor/new")]
    public ActionResult New()
    {
      return View(); 
    }

    [HttpPost("/vendor")]
    public ActionResult Create(string vendorName)
    {
      Vendor newVendor = new Vendor (vendorName);
      return RedirectToAction("Index", newVendor);
    }

    [HttpGet("/vendor/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> orderItems = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("order", orderItems);
      return View(model);
    }

    [HttpPost("/vendor/{vendorId}/order")]
    public ActionResult Create(int vendorId, string title, string description, string price, string date)
    {
      Vendor selectedVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(title, description, price, date);
      selectedVendor.AddOrder(newOrder);
      List<Order> orderItems = Order.GetList();
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", orderItems);
      model.Add("vendor", selectedVendor);
      return View("Show", model);
    }

    [HttpPost("/vendor/{vendorId}/order/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      Order order = Order.FindOrder(orderId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(vendorId);
      List<Order> orderItems = Order.GetList();
      model.Add("vendor", vendor);
      model.Add("order", order);
      return View(model);
    }

  }
}