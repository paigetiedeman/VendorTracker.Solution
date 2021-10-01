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
      return RedirectToAction("Index");
    }
  }
}