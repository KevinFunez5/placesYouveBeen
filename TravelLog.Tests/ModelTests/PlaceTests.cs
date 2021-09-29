using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TravelLog.Models;
using System;

namespace TravelLog.Tests
{
  [TestClass]
  public class PlaceTest
  {
    [TestMethod]
    public void PlaceConstructor_CreateInstanceOfPlace_Place()
    {
      Place newPlace = new Place("New York");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }
  }
}