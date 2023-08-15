using Microsoft.AspNetCore.Mvc;
using System;

namespace shop.webui.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            string mesaj = saat > 12 ? "İyi Günler" : "Günaydın";
            ViewBag.Username = "Ahmet";
            ViewBag.Greeting = mesaj;
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
