using Microsoft.AspNetCore.Mvc;

namespace RecipeBook.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }
  }
}