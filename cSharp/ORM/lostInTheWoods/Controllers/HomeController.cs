using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using lostInTheWoods.Models;
using lostInTheWoods.Factory;

namespace lostInTheWoods.Controllers
{
    public class HomeController : Controller
    {
        private readonly TrailFactory trailFactory;
        public HomeController(TrailFactory _trailfactory)
        {
            trailFactory = _trailfactory;
        }

        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.Trails = trailFactory.FindAll();
            return View("Index");
        }

        [HttpGet]
        [Route("NewTrail")]
        public IActionResult NewTrail()
        {
            return View("NewTrail");
        }

        [HttpGet]
        [Route("trails/{id}")]
        public IActionResult TrailPage(int id)
        {
            ViewBag.trail = trailFactory.FindId(id);
            return View("TrailPage");
        }

        [HttpPost]
        [Route("create")]
        public IActionResult createTrail(Trail trail)
        {
            if(ModelState.IsValid)
            {
                trailFactory.Add(trail);
                System.Console.WriteLine(trail);
                return RedirectToAction("Index");
            }
            else
            {
                return View("NewTrail");
            }
        }




    }
}
