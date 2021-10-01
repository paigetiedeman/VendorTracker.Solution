using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;
using System.Collections.Generic;

namespace VendorTracker.Controllers
{
  public class OrderController : Controller
  {
    [HttpPost("/order/{id}")]
    public ActionResult Show(int id)
    {
      Vendor selectedVendor = Vendor.Find(id);
      return View(selectedVendor);
    }
  }
}