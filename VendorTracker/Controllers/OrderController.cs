using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;
using System.Collections.Generic;

namespace VendorTracker.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/vendor/{id}/order/new")]
    public ActionResult New(int id)
    {
      Vendor selectedVendor = Vendor.Find(id);
      return View(selectedVendor);
    }
    // [HttpPost("/order/{id}")]
    // public ActionResult Show(int id)
    // {
    // }
  }
}