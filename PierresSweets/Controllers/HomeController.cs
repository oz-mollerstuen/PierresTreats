using Microsoft.AspNetCore.Mvc;
using PierresSweets.Models;
using System.Collections.Generic;
using System.Linq;

namespace PierresSweets.Controllers
{
  public class HomeController : Controller
  {

    private readonly PierresSweetsContext _db;

    public HomeController(PierresSweetsContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      ViewBag.Flavor = new List<Flavor>( _db.Flavors);
      ViewBag.Treat = new List<Treat>( _db.Treats);
      return View( _db.Flavors.ToList());
    }
  }
}