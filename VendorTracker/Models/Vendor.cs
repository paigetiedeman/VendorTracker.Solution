using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Vendor 
  {
    public string VendorName { get; set; }
    public int Id {get; }
    private static List<Vendor> _instances = new List<Vendor>{};

    public Vendor(string vendorName) 
    {
      VendorName = vendorName;
      Id = _instances.Count;
      _instances.Add(this);
    }
    public static List<Vendor> GetVendors()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Vendor Find(int ID)
    {
      return _instances[ID - 1];
    }
  }
}