using Microsoft.AspNetCore.Mvc;

namespace Fruit_N12.Areas.Admin.Controllers
{
    public class FileManagerController : Controller
    {
        [Area("Admin")]
        [Route("/Admin/file-manager")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
