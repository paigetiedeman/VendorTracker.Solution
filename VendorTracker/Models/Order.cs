using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    // Title, description, price, date

    public Order(string title)
    {
      Title = title;
    }
  }
}