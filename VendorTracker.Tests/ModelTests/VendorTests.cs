using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using VendorTracker.Models;

namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

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

    [TestMethod]
    public void GetVendors_ReturnsEmptyList_VendorList()
    {
      List<Vendor> newList = new List<Vendor> {};
      List<Vendor> result = Vendor.GetVendors();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetVendors_ReturnsVendorList_VendorList()
    {
      Vendor newVendor = new Vendor("Suzie's Cafe");
      Vendor newVendor2 = new Vendor("Barry's");
      List<Vendor> newList = new List<Vendor> {newVendor, newVendor2};
      List<Vendor> result = Vendor.GetVendors();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Vendor_ConstructorAssignsId_True()
    {
      string vendorName = "Suzie's Cafe";
      Vendor newVendor = new Vendor(vendorName);
      Assert.AreEqual(0, newVendor.Id);
    }
    [TestMethod]
    public void Vendor_ConstructorAssignsIds_True()
    {
      string vendorName = "Suzie's Cafe";
      string vendorName2 = "Barry's";
      Vendor newVendor = new Vendor(vendorName);
      Vendor newVendor2 = new Vendor(vendorName2);
      Assert.AreEqual(1, newVendor2.Id);
    }
  }
}