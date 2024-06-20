using Microsoft.AspNetCore.Mvc;
using ProjeOdev.Models;

namespace ProjeOdev.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }
        public int Index3()
        {
            return 55;
        }
        public string Index4()
        {
            return "eşek emirhan";
        }
        public IActionResult Gym()
        {
            var gyms = new List<Gym>()
            {
                new Gym() { Id = 1, Interests = "Crossfit", Name = "Talha Kara", Trainer = "Tugrul Donmez" },
                new Gym() { Id = 2, Interests = "BodyBuilding", Name = "Emirhan Ozcan", Trainer = "Tugrul Donmez" }
            };

            return View(gyms);
        }
        public IActionResult Index5()
        {
            ViewBag.deg1 = "Her üyenin sahip olabileceği Personal Trainer sayısı :";
            ViewBag.deg2 = 1;

            return View();
        }
        public IActionResult Index6()
        {
            return View();
        }
        public IActionResult Index7()
        {
            return View();
        }
        public IActionResult Index8()
        {
            return View();
        }
        public IActionResult Index9()
        {
            return View();
        }
        public IActionResult Index10()
        {
            return View();
        }
    }
}
