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
      Order newVendor = new Order("title test", "description test");
      Assert.AreEqual(typeof(Order), newVendor.GetType());
    }
    [TestMethod]
    public void GetSetTitle_ReturnsOrderTitle_String()
    {
      string title = "Order 1";
      Order newOrder = new Order(title, "description test");
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }
    [TestMethod]
    public void GetSetDescription_ReturnsOrderDescription_String()
    {
      string title = "Order 1";
      string description = "1 Pastry";
      Order newOrder = new Order(title, description);
      string newDescription = newOrder.Description;
      Assert.AreEqual(description, newDescription);
    }
  }
}