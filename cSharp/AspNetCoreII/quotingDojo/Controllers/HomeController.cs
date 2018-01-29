using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using DbConnection;

namespace quotingDojo.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            
            return View("Index");
        }

        [HttpGet]
        [Route("quotes")]
        public IActionResult Result()
        {
            string query = "SELECT * FROM quotes";
            List<Dictionary<string, object>> allquotes = DbConnector.Query(query);
            ViewBag.quotes = allquotes;
            return View("Result");
        }
        [HttpPost]
        [Route("createQuote")]
        public IActionResult Create(string username, string userquote)
        {
            string iusername = '"' + username + '"';
            string iuserquote = '"' + userquote + '"';
            string iquery = $"INSERT INTO quotes(name, text, created_at)VALUES({iusername}, {iuserquote}, NOW());";  
            DbConnector.Execute(iquery);
            return RedirectToAction("Result");
        }

        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            int quoteId = id;
            string iquery = $"DELETE FROM quotes WHERE (id = {quoteId});"; 
            DbConnector.Execute(iquery);
            return RedirectToAction("Result");
        }
    }
}
