using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
    namespace portfolio.Controllers
        {
            public class HomeController : Controller
            {
                [HttpGet]
                [Route("")]
                public IActionResult Home()
                {
                    return View("home");
                }

                [HttpGet]
                [Route("project")]
                public IActionResult Project()
                {
                    return View("project");
                }

                [HttpGet]
                [Route("contact")]
                public IActionResult Contact()
                {
                    return View("contact");
                }
            }
        }