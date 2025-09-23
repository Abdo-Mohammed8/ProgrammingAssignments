using Microsoft.AspNetCore.Mvc;
using MVC01_DEMO.Models;

namespace MVC01_DEMO.Controlles
{
    public class MoviesController:Controller
    {
        //public string Index(int? id)
        //{
        //    return string.Empty;
        //}
        public string Index()
        {
            return $"Hello from index"
            ;
        }

        // get baseurl/Movie/GetMovie?id=10&name=filemname
        //[HttpGet]
        //public ContentResult GetMovie(int? id , string name)
        //{
        //    //ContentResult result = new ContentResult();

        //    //result.Content = $"Movie :: {id} </br> {name}";
        //    //result.ContentType = "text/html" ;
        //    ////result.StatusCode = 700 ;
        //    //return result;
        //    return Content($"Movie :: {id} </br> {name}" , "text/html");

        //}

        [HttpGet]
        public ContentResult GetMovie(int? id, string name)
        {
            //if id = 0 -> vad req
            //id <10 -> notfound
            //id >= 10 - > data

            //if (id == 0) return BadRequest();
            //else if (id < 10) return NotFound();
             return Content($"Movie :: {id} </br> {name}", "text/html");
        }

        [HttpGet]
        public IActionResult Test() {

            //return RedirectToAction("GetMovie"); // in the same controller

            return RedirectToAction(nameof(GetMovie) , "Movies" , new {id = 15 , name = "test"}); // defferent controller

            //return Redirect("https://www.google.com");

        }

        [HttpPost]
        public IActionResult TestModelBindeing([FromRoute]int id ,[FromQuery] string name)
        {
            return Content($"hello {name} your id is : {id}");
        }
        [HttpPost]

        public IActionResult AddMovie(string Title, Movie movie, int Id , int[]arr)
        {
            if (movie is null) return BadRequest();
            else return Content($"hello {arr[0]} your id is {arr[1]}");
        }
    }
}
