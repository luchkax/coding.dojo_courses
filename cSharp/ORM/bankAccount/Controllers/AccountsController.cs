using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Linq;
using bankAccount.Models;
using Microsoft.AspNetCore.Identity;

namespace bankAccount.Controllers
{
    public class AccountsController : Controller
    {
        private BankContext _context;
        public AccountsController(BankContext context)
        {
            _context = context;
        }
    
        [HttpGet]
        [Route("account/{userID}")]
        public IActionResult Home(int userID)
        {

            int? id = HttpContext.Session.GetInt32("userId");
            if(id == null)
            {
                return RedirectToAction("LoginUser", "Users");
            }
            else
            {   
                List<Transaction> Transactions = _context.Transactions.Where(t=>t.UserId == id).ToList();
                ViewBag.transactions = Transactions;
                User loggedUser = _context.Users.Where(u=>u.UserId == id).SingleOrDefault();
                TempData["Balance"] = loggedUser.Balance;
                TempData["Name"] = HttpContext.Session.GetString("userFirstName");
                User user = _context.Users.Where(u=>u.UserId == id).SingleOrDefault();
                return View("Account");
            }
        }

        [HttpPost]
        [Route("transaction")]
        public IActionResult Transaction (double amount)
        {
            if(amount != 0)
            {
                int? id = HttpContext.Session.GetInt32("userId");
                if(id == null)
                {
                    return RedirectToAction("LoginUser", "Users");
                }
                Transaction newTransaction = new Transaction
                {
                    UserId = (int)id,
                    Amount = amount,
                    Date = DateTime.Now
                };
                User user = _context.Users.Where(u => u.UserId == newTransaction.UserId).SingleOrDefault();
                user.Balance = user.Balance + (double)newTransaction.Amount;
                _context.Add(newTransaction);
                _context.SaveChanges();
                System.Console.WriteLine("added----------------------------");
                return RedirectToAction("Home", new {userID = id});
            } 
            else
            {
                return View("Account");
            }
        }
    }
}
