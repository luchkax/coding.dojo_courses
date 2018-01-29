using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
 
    namespace dojodachi.Controllers
    {
        public class HomeController : Controller
        {
            [HttpGet]
            [Route("")]
            public IActionResult Index()
            {
                TempData["gameStatus"] = "Playing";
                
                int? happiness = HttpContext.Session.GetInt32("happiness");
                if(happiness == null)
                {
                    HttpContext.Session.SetInt32("happiness", 20);
                    TempData["message"] = "Hello, meet your Dojonachi";
                }

                int? fullness = HttpContext.Session.GetInt32("fullness");
                if(fullness == null)
                {
                    HttpContext.Session.SetInt32("fullness", 20);
                }

                int? energy = HttpContext.Session.GetInt32("energy");
                if(energy == null)
                {
                    HttpContext.Session.SetInt32("energy", 50);
                }
                int? meals = HttpContext.Session.GetInt32("meals");
                if(meals == null)
                {
                    HttpContext.Session.SetInt32("meals", 3);
                }
                if(fullness <= 0 || happiness <= 0)
                {
                    TempData["message"] = "Oh, your Dojodachi is dead, try new game";
                    TempData["gameStatus"] = "over";
                }
                if(energy >= 100 && fullness >= 100 && happiness >= 100)
                {
                    TempData["message"] = "Your Dojodachi is the happiest dojodachi in the world. You WON";
                    TempData["gameStatus"] = "over";
                }
                TempData["happiness"] = HttpContext.Session.GetInt32("happiness");
                TempData["fullness"] = HttpContext.Session.GetInt32("fullness");
                TempData["energy"] = HttpContext.Session.GetInt32("energy");
                TempData["meals"] = HttpContext.Session.GetInt32("meals");

                return View();
            }
            [HttpGet]
            [Route("/feed")]
            public IActionResult Feed()
            {
                if(HttpContext.Session.GetInt32("meals") > 0)
                {
                    int? meals = HttpContext.Session.GetInt32("meals") - 1;
                    HttpContext.Session.SetInt32("meals", (int)meals);
                    Random rand1 = new Random();
                    int? gained = rand1.Next(5,11);
                    if(gained == 1)
                    {
                        TempData["message"] = "Your Dojodachi doesn't like this meal!";   
                    } 
                    else
                    {
                        Random rand2 = new Random();
                        int wellGained = rand2.Next(5,11);
                        int? fullness = HttpContext.Session.GetInt32("fullness") + wellGained;
                        HttpContext.Session.SetInt32("fullness", (int)wellGained);
                        TempData["message"] = $"Your Dojodachi like this meal! Your fullness increased by {wellGained} points";   
                    }
                }
                else
                {
                    TempData["message"] = "You don't have any meals!";   
                }
                return RedirectToAction("Index");
            }
            [HttpGet]
            [Route("/play")]
            public IActionResult Play()
            {
                if(HttpContext.Session.GetInt32("energy") >= 5)
                {
                    int? energy = HttpContext.Session.GetInt32("energy") - 5;
                    HttpContext.Session.SetInt32("energy", (int)energy);
                    Random rand3 = new Random();
                    int? gained = rand3.Next(5,11);
                    if(gained == 1)
                    {
                        TempData["message"] = "Your Dojodachi doesn't like this meal!";   
    
                    }
                    else
                    {
                        Random rand4 = new Random();
                        int? happiness = HttpContext.Session.GetInt32("happiness") + rand4.Next(5,11);
                        HttpContext.Session.SetInt32("happiness", (int)happiness);
                        TempData["message"] = $"You played with your Dojodachi and increased happiness by {rand4.Next(5,11)}";  
                    }
                }
                else
                {
                    TempData["message"] = "You don't have enough energy!";   
                }
                return RedirectToAction("Index");
            }

            [HttpGet]
            [Route("/work")]
            public IActionResult Work()
            {
                if(HttpContext.Session.GetInt32("energy") >= 5)
                {
                    int? energy = HttpContext.Session.GetInt32("energy") - 5;
                    HttpContext.Session.SetInt32("energy", (int)energy);
                    Random rand = new Random();
                    int gained = rand.Next(1,4);
                    int? meals = HttpContext.Session.GetInt32("meals") + gained;
                    HttpContext.Session.SetInt32("meals", (int)meals);
                    TempData["message"] = $"Your Dojodachi worked and earned {gained} meals";
                }
                else
                {
                    TempData["message"] = "You don't have enough energy!";
                }
                return RedirectToAction("Index");
            }

            [HttpGet]
            [Route("/sleep")]
            public IActionResult Sleep()
            {
                // if((HttpContext.Session.GetInt32("happiness")) >= 5 && (HttpContext.Session.GetInt32("fullness") >= 5))
                // {
                //     TempData["message"] = "You don't have enough fullness and happiness!";
                // }
                // else if((HttpContext.Session.GetInt32("happiness")) >= 5 || (HttpContext.Session.GetInt32("fullness") >= 5))
                // {
                //     TempData["message"] = "You don't have enough fullness or happiness!";
                // }
                // else
                // {
                    int? happiness = HttpContext.Session.GetInt32("happiness");
                    HttpContext.Session.SetInt32("happiness", (int)happiness - 5);
                    int? fullness = HttpContext.Session.GetInt32("fullness");
                    HttpContext.Session.SetInt32("fullness", (int)fullness -5);
                    int? energy = HttpContext.Session.GetInt32("energy");
                    HttpContext.Session.SetInt32("energy", (int)energy +15);
                    TempData["message"] = "Your energy gained 15, but you lost 5 happiness and fullness!";
                // }   
                return RedirectToAction("Index");
            }

            [HttpGet]
            [Route("/reset")]
            public IActionResult Reset()
            {
                HttpContext.Session.Clear();
                return RedirectToAction("Index");
            }
        }
    }