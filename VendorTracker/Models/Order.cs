using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    // Title, description, price, date

    public Order(string title, string description)
    {
      Title = title;
      Description = description;
    }
  }
}