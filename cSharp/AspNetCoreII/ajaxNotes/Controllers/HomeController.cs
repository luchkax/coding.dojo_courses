using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace ajaxNotes.Controllers
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
            string query = "SELECT * FROM notes";
            var notes = _dbConnector.Query(query);
            ViewBag.notes = notes;
            return View();
        }

        [HttpPost]
        [Route("newNote")]
        public IActionResult createNote(string title, string description)
        {
            string titleString =  title;
            string descriptionString = description;
            string query = $"INSERT INTO notes(title, description, created_at)VALUES('{titleString}', '{descriptionString}', NOW());";
            _dbConnector.Execute(query);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult deleteNote(int id)
        {
            int noteId = id;
            string query = $"DELETE FROM notes WHERE(id = {noteId})";
            _dbConnector.Execute(query);
            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("update/{id}")]
        public IActionResult updateNote(int id, string description)
        {
            int noteId = id;
            string query =  $"UPDATE notes SET description = '{description}' WHERE id = {id}";
            _dbConnector.Execute(query);
            return RedirectToAction("Index");
        }
    }
}