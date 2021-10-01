using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using VendorTracker.Models;

namespace VendorTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newVendor = new Order("title test");
      Assert.AreEqual(typeof(Order), newVendor.GetType());
    }
    [TestMethod]
    public void GetSetTitle_ReturnsOrderTitle_String()
    {
      string title = "Order 1";
      Order newOrder = new Order(title);
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }
  }
}