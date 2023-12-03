using Microsoft.AspNetCore.Mvc;

namespace online_order.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
