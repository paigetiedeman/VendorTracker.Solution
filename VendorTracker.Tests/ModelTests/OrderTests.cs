using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using VendorTracker.Models;

namespace VendorTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newVendor = new Order("title test", "description test", "price test", "date test");
      Assert.AreEqual(typeof(Order), newVendor.GetType());
    }
    [TestMethod]
    public void GetSetTitle_ReturnsOrderTitle_String()
    {
      string title = "Order 1";
      Order newOrder = new Order(title, "description test", "price test", "date test");
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void GetSetDescription_ReturnsOrderDescription_String()
    {
      string title = "Order 1";
      string description = "1 Pastry";
      Order newOrder = new Order(title, description, "price test", "date test");
      string newDescription = newOrder.Description;
      Assert.AreEqual(description, newDescription);
    }

    [TestMethod]
    public void GetSetPrice_ReturnsOrderPrice_String()
    {
      string title = "Order 1";
      string description = "1 Pastry";
      string price = "5";
      Order newOrder = new Order(title, description, price, "date test");
      string newPrice = newOrder.Price;
      Assert.AreEqual(price, newPrice);
    }

    [TestMethod]
    public void GetSetDate_ReturnsOrderDate_String()
    {
      string title = "Order 1";
      string description = "1 Pastry";
      string price = "5";
      string date = "Oct. 1";
      Order newOrder = new Order(title, description, price, date);
      string newDate = newOrder.Date;
      Assert.AreEqual(date, newDate);
    }

    [TestMethod]
    public void GetOrders_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> {};
      List<Order> result = Order.GetList();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetList_ReturnsOrdersList_OrderList()
    {
      string title = "Order 1";
      string description = "1 Pastry";
      string price = "5";
      string date = "Oct. 1";
      Order newOrder = new Order(title, description, price, date);
      List<Order> newList = new List<Order> {newOrder};
      List<Order> resultList = Order.GetList();
      CollectionAssert.AreEqual(newList, resultList);
    }
    [TestMethod]
    public void Order_ConstructorAssignsId_True()
    {
      string title = "Order 1";
      string description = "1 Pastry";
      string price = "5";
      string date = "Oct. 1";
      Order newOrder = new Order(title, description, price, date);
      Assert.AreEqual(0, newOrder.Id);
    }
    [TestMethod]
    public void FindOrder_ReturnsCorrectOrderById_Order()
    {
      string title = "Suzie's Cafe";
      string title2 = "Barry's";
      Order newOrder = new Order(title, "description test", "price test", "date test");
      Order newOrder2 = new Order(title2, "description test", "price test", "date test");
      Order result = Order.FindOrder(2);
      Assert.AreEqual(newOrder2, result);
    }
  }
}