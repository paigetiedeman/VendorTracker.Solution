using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;
using System.Collections.Generic;

namespace VendorTracker.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/vendor/{vendorId}/order/new")]
    public ActionResult New(int vendorId)
    {
      Vendor newVendor = Vendor.Find(vendorId);
      return View(newVendor);
    }
    // [HttpPost("/order/{id}")]
    // public ActionResult Show(int id)
    // {
    // }
  }
}