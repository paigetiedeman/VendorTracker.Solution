using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Vendor 
  {
    public string VendorName { get; }

    public Vendor(string vendorName) 
    {
      VendorName = vendorName;
    }
  }
}