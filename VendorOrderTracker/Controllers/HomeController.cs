using Microsoft.AspNetCore.Mvc;

namespace VendorOrderTracker.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      // Display the splash page
      return View();

    }
  }
}
