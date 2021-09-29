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

    [HttpGet("/place")]
    public ActionResult Create(string cityName)
    {
      Place newPlace = new Place(cityName);
      return RedirectToAction("Index");
    }
  }
}