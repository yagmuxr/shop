using Microsoft.AspNetCore.Mvc;

namespace shop.webui.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult index()
        {
            return View();
        }
        public IActionResult details()
        {
            return View();
        }
    }
}
