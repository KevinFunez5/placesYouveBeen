using System.Collections.Generic;

namespace TravelLog.Models
{
  public class Place
  {
    
    public string CityName {get; set;}
    private static List<Place> _instances = new List<Place> {};
    public int Id {get;}

    public Place(string cityName)
    {
      CityName = cityName;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Place> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Place Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}