using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace rapperAPI.Controllers {

    
    public class ArtistController : Controller {

        private List<Artist> allArtists;

        public ArtistController() {
            allArtists = JsonToFile<Artist>.ReadJson();
        }

        //This method is shown to the user navigating to the default API domain name
        //It just display some basic information on how this API functions
        [Route("")]
        [HttpGet]
        public string Index() {
            allArtists = JsonToFile<Artist>.ReadJson();
            //String describing the API functionality
            string instructions = "Welcome to the Music API~~\n========================\n";
            instructions += "    Use the route /artists/ to get artist info.\n";
            instructions += "    End-points:\n";
            instructions += "       *Name/{string}\n";
            instructions += "       *RealName/{string}\n";
            instructions += "       *Hometown/{string}\n";
            instructions += "       *GroupId/{int}\n\n";
            instructions += "    Use the route /groups/ to get group info.\n";
            instructions += "    End-points:\n";
            instructions += "       *Name/{string}\n";
            instructions += "       *GroupId/{int}\n";
            instructions += "       *ListArtists=?(true/false)\n";
            return instructions;
        }

        [Route("artists")]
        [HttpGet]
        public JsonResult Artists() 
        {
            return Json(allArtists);
        }

        [Route("artists/{name}")]
        [HttpGet]
        public JsonResult ArtistsByName(string name) 
        {
            var artist = allArtists.Where(a=>a.ArtistName == name).SingleOrDefault();
            return Json(artist);
        }

        [Route("artists/realname/{realname}")]
        [HttpGet]
        public JsonResult ArtistsRealName(string realname) 
        {
            var artist = allArtists.Where(a=>a.RealName == realname).SingleOrDefault();
            return Json(artist);
        }
        [Route("artists/hometown/{town}")]
        [HttpGet]
        public JsonResult ArtistsHomeTown(string town) 
        {
            var artists = allArtists.Where(a=>a.Hometown == town).ToList();
            return Json(artists);
        }

        [Route("artists/id/{id}")]
        [HttpGet]
        public JsonResult ArtistsGroup(int id) 
        {
            var artists = allArtists.Where(a=>a.GroupId == id).ToList();
            return Json(artists);
        }
        
        


    }
}