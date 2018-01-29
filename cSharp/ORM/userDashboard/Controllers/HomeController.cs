using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Linq;
using userDashboard.Models;
using Microsoft.AspNetCore.Identity;

namespace userDashboard.Controllers
{
    public class HomeController : Controller
    {
        private DashContext _context;
        public HomeController(DashContext context)
        {
            _context = context;
        }
        // GET: /Home/
        [HttpGet]
        [Route("dashboard/admin")]
        public IActionResult AdminDash()
        {
            int? id = HttpContext.Session.GetInt32("userId");
            if(id == null)
            {
                return RedirectToAction("LoginUser", "Users");
            }
            else
            {
                User LoggedUser = _context.Users.Where(u=>u.UserId == id).SingleOrDefault();
                if(LoggedUser.UserLevel == "Admin")
                {
                    List<User> allUsers =  _context.Users.Where(user => user.UserId > 0).ToList();
                    ViewBag.users = allUsers;
                    ViewBag.userId = id;
                    return View("DashAdmin");
                }
                else
                {
                    return RedirectToAction("Dash");
                }
            }
        }

        [HttpGet]
        [Route("dashboard")]
        public IActionResult Dash()
        {
            int? id = HttpContext.Session.GetInt32("userId");
            if(id == null)
            {
                return RedirectToAction("LoginUser", "Users");
            }
            else
            {
                User LoggedUser = _context.Users.Where(u=>u.UserId == id).SingleOrDefault();
                if(LoggedUser.UserLevel != "Admin")
                {
                    List<User> allUsers =  _context.Users.Where(user => user.UserId > 0).ToList();
                    ViewBag.users = allUsers;
                    ViewBag.userId = id;
                    return View("Dash");
                }
                else
                {
                    return RedirectToAction("AdminDash");
                }
            }
            
        }

        [HttpGet]
        [Route("/users/{userId}")]
        public IActionResult UserPage()
        {
            int? id = HttpContext.Session.GetInt32("userId");
            if(id == null)
            {
                return RedirectToAction("LoginUser", "Users");
            }
            else
            {
                User LoggedUser = _context.Users.Where(u=>u.UserId == id).SingleOrDefault();
                ViewBag.loggeduser = LoggedUser;
            }
           

            return View("User");
        }

        [HttpGet]
        [Route("users/new")]
        public IActionResult AdminNewUser()
        {
            int? id = HttpContext.Session.GetInt32("userId");
            if(id == null)
            {
                return RedirectToAction("LoginUser", "Users");
            }
            else
            {
                ViewBag.userId = id;
                return View("NewUser");
            }
        }

        [HttpPost]
        [Route("registerinside")]
        public IActionResult RegisterInside(Register regUser)
        {   
            if(ModelState.IsValid)
            {
                User exists = _context.Users.SingleOrDefault(user=>user.Email == regUser.Email);
                if(exists !=null)
                {
                    ModelState.AddModelError("Email", "An account with this email already exists!");
                    return View("AdminNewUser");
                }
                else
                {
                    PasswordHasher<Register> Hasher = new PasswordHasher<Register>();
                    string hashed = Hasher.HashPassword(regUser, regUser.Password);
                    User newUser = new User
                    {
                        FirstName = regUser.FirstName,
                        LastName = regUser.LastName,
                        Email = regUser.Email,  
                        Password = hashed,
                        UserLevel = "Normal"
                    };
                    _context.Add(newUser);
                    _context.SaveChanges();

                    return RedirectToAction("AdminDash");
                }
            }
            else
            {
                return View("AdminNewUser");
            }
        }



        [HttpGet]
        [Route("users/edit/{userId}")]
        public IActionResult EditUser()
        {
            int? id = HttpContext.Session.GetInt32("userId");
            if(id == null)
            {
                return RedirectToAction("LoginUser", "Users");
            }
            else
            {
                ViewBag.userId = id;
                return View("EditUser");
            }
        }

        [HttpGet]
        [Route("users/edit")]
        public IActionResult AdminEditUser()
        {

            return View("AdminEditUser");
        }
    }
}
