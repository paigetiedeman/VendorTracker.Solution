using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Vendor 
  {
    public string VendorName { get; set; }

    public Vendor(string vendorName) 
    {
      VendorName = vendorName;
    }
  }
}