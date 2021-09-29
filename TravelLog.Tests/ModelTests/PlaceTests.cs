using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TravelLog.Models;
using System;

namespace TravelLog.Tests
{
  [TestClass]
  public class PlaceTest : IDisposable
  {
    public void Dispose()
    {
      Place.ClearAll();
    }

    [TestMethod]
    public void PlaceConstructor_CreateInstanceOfPlace_Place()
    {
      Place newPlace = new Place("New York");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    [TestMethod]
    public void PlaceConstructor_GetProperty_NewYork()
    {
      Place newPlace = new Place("New York");
      Assert.AreEqual("New York", newPlace.CityName);
    }

    [TestMethod]
    public void PlaceConstructor_GetID_1()
    {
      Place newPlace = new Place("New York");
      Assert.AreEqual(1, newPlace.Id);
    }
    
    [TestMethod]
    public void UpdatePlace_UpdateCityName_Portland()
    {
      Place newPlace = new Place("New York");
      newPlace.CityName = "Portland";
      Assert.AreEqual("Portland", newPlace.CityName);
    }

    [TestMethod]
    public void GetAll_ReturnPlaces_PlaceList()
    {
      Place newPlace = new Place("New York");
      Place anotherPlace = new Place("Portland");
      List<Place> placeList = new List<Place> {newPlace, anotherPlace};
      List<Place> result = Place.GetAll();
      CollectionAssert.AreEqual(placeList, result);
    }

    [TestMethod]
    public void Find_ReturnCorrectPlace_AnotherPlace()
    {
      Place newPlace = new Place("New York");
      Place anotherPlace = new Place("Portland");
      Place result = Place.Find(2);
      Assert.AreEqual(anotherPlace, result);
    }
  }
}
