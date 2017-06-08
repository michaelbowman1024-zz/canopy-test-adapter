using CanopyTestAdapter.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CanopyTestAdapter.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Selection()
        {
            return View(new List<Test>()
            {
                new Test()
                {
                    Id = 1,
                    Title = "Test",
                    IsSelected = false
                }
            });
        }

        public IActionResult Report()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
