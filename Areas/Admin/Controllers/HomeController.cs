using Microsoft.AspNetCore.Mvc;

namespace Fruit_N12.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {

        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
