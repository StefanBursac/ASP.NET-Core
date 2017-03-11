using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VezbaAPI.Models;

namespace VezbaAPI.Controllers
{

    [Route("")]

    

        public class MovieController : Controller
    {

        public HelloWorld()
        {
            Console.Write("Hello World");
        }


        [HttpGet("{movies}")]
        public JsonResult GetMovies()
        {
            return new JsonResult(new List<object>()

            {
                new Movie {Name = "m" },
                new Movie { Name = "mm" }
            });

            
            
        }
        
        
        
        
        




    }
}
