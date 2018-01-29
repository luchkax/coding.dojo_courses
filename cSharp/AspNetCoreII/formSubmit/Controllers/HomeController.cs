using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using formSubmit.Models;

namespace formSubmit.Controllers
{
    public class HomeController : Controller
    {
        private readonly DbConnector _dbConnector;
 
        public HomeController(DbConnector connect)
        {
            _dbConnector = connect;
        }

        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View("Index");
        }
        [HttpPost]
        [Route("register")]
        public IActionResult Register(string FirstName, string LastName, int Age, string Email, string Password)
        {
            User user = new User
            {
                FirstName = FirstName,
                LastName = LastName,
                Age = Age,
                Email = Email,
                Password = Password
            };
            if(TryValidateModel(user) == false)
            {
                ViewBag.Errors = ModelState.Values;
                return View("Errors");
            }
            return RedirectToAction("Success");
        }
        [HttpGet]
        [Route("success")]
        public IActionResult Success()
        {
            return View("Success");
        }
    }

}
