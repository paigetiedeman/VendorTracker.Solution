using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public string Price { get; set; }
    public string Date { get; set; }
    public int Id {get; }
    private static List<Order> _orderInstances = new List<Order>{};
    

    public Order(string title, string description, string price, string date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      Id = _orderInstances.Count;
      _orderInstances.Add(this);
    }
    public static List <Order> GetList()
    {
      return _orderInstances;
    }
    public static void ClearAll()
    {
      _orderInstances.Clear();
    }

    public static Order FindOrder(int ID)
    {
      return _orderInstances[ID - 1];
    }
  }
}