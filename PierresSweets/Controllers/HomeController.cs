using Microsoft.AspNetCore.Mvc;
using PierresSweets.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace PierresSweets.Controllers
{
  public class HomeController : Controller
  {
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly PierresSweetsContext _db;

    public HomeController(UserManager<ApplicationUser> userManager, PierresSweetsContext db)
    {
      _userManager = userManager;
      _db = db;
    }

   [HttpGet("/")]
    public ActionResult Index()
    {
      Treat[] treats = _db.Treats.ToArray();
      Flavor[] flavors = _db.Flavors.ToArray();
      Dictionary<string, object[]> model = new Dictionary<string, object[]>();
      model.Add("treats", treats);
      model.Add("flavors", flavors);
      return View(model);
    }
  }
}