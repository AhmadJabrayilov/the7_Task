using Microsoft.AspNetCore.Mvc;

namespace The7_BackEnd.Areas.Admin.Controllers
{
    public class ServiceController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
