using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using dojoLeague.Models;
using dojoLeague.Factory;

namespace dojoLeague.Controllers
{
    public class NinjaController : Controller
    {
        private readonly DojoFactory dojoFactory;
        private readonly NinjaFactory ninjaFactory;
        public NinjaController(DojoFactory _dojofactory, NinjaFactory _ninjafactory)
        {
            dojoFactory = _dojofactory;
            ninjaFactory = _ninjafactory;
        }
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.allDojos = dojoFactory.FindAll();
            ViewBag.allNinjas = ninjaFactory.FindAll();
            return View();
        }
        [HttpPost]
        [Route("addNinja")]
        public IActionResult addNinja(Ninja ninja)
        {
            if(ModelState.IsValid)
            {
                ninjaFactory.Add(ninja);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.allDojos = dojoFactory.FindAll();
                ViewBag.allNinjas = ninjaFactory.FindAll();
                return View("Index");
            }
        }
        [HttpGet]
        [Route("ninja/{id}")]
        public IActionResult Ninja(int id)
        {
            var ninja = ninjaFactory.FindByID(id);
            if(ninja == null){
                ViewBag.ninja = ninjaFactory.FindRogueNinjaByID(id);
                return View("RogueNinja");
            }
            else{
                ViewBag.ninja = ninjaFactory.FindByID(id);
                return View();
            }
            
            
        }

    }
}