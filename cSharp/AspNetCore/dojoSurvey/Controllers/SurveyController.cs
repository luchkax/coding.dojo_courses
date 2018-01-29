using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
 
namespace dojoSurvey.Controllers
    {
        public class SurveyController : Controller
        {
            [HttpGet]
            [Route("")]
            public IActionResult Index()
            {
                return View("index");
            }

            [HttpGet]
            [Route("result")]
            public IActionResult Result()
            {
                return View("result");
            }
            
            [HttpPost]
            [Route("process")]
            public IActionResult Result(string name, string location, string language, string comment)
            {
                ViewBag.name = name;
                ViewBag.location = location;
                ViewBag.language = language;
                ViewBag.comment = comment;
                return View("result");
            }
        }
    }