using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using VendorTracker.Models;

namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetVendorName_ReturnsVendorName_String()
    {
      string vendorName = "Suzie's Cafe";
      Vendor newVendor = new Vendor(vendorName);
      string result = newVendor.VendorName;
      Assert.AreEqual(vendorName, result);
    }
    [TestMethod]
    public void SetVendorName_SetsVendorName_String()
    {
      string vendorName = "Suzie's Cafe";
      Vendor newVendor = new Vendor(vendorName);
      string vendorName2 = "Barry's";
      newVendor.VendorName = vendorName2;
      string result = newVendor.VendorName;
      Assert.AreEqual(vendorName2, result);
    }
  }
}