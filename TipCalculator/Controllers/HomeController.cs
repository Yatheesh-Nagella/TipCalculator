using Microsoft.AspNetCore.Mvc;
using TipCalculator.Models;

namespace TipCalculator.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.fifteen = 0;
            ViewBag.twenty = 0;
            ViewBag.twentyfive = 0;
            return View();
        }
        [HttpPost]
        public IActionResult Index(TipCalculatorModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.fifteen = model.CalculateTip(15);
                ViewBag.twenty = model.CalculateTip(20);
                ViewBag.twentyfive = model.CalculateTip(25);
            }
            return View(model);
        }
    }
}