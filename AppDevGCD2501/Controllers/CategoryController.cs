using Microsoft.AspNetCore.Mvc;

namespace AppDevGCD2501.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Hello()
        {
            return View();
        }
    }
}
