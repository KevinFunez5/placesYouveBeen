using Microsoft.AspNetCore.Mvc;
using TravelLog.Models;

namespace TravelLog.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index() { return View(); }

    // add additional paths with the format:
  
    // [Route("/pathName")]
    // public string PathName() 
    //  {
    //    add code here! add variables, use Models elements, etc.
    //    return "Always return something!"
    //  }
  }
}