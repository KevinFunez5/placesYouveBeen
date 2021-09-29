using Microsoft.AspNetCore.Mvc;
using TravelLog.Models;
using System.Collections.Generic;

namespace TravelLog.Controllers
{
  public class PlaceController : Controller
  { 
    [HttpGet("/place")]
    public ActionResult Index()
    {
      List<Place> allPlace = Place.GetAll();
      return View(allPlace);
    }

    [HttpGet("/place/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/place")]
    public ActionResult Create(string cityName)
    {
      Place newPlace = new Place(cityName);
      return RedirectToAction("Index");
    }

    [HttpGet("/place/{Id}")]
    public ActionResult Show(int Id)
    {
      Place selectedPlace = Place.Find(Id);
      return View(selectedPlace);

    }

    [HttpPost("/place/{Id}")]
    public ActionResult Destroy(int Id)
    {
      Place selectedPlace = Place.Find(Id);
      selectedPlace.Delete();
      return View();
    }
  }
}