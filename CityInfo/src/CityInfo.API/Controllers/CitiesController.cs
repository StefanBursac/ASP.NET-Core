﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Controllers
{
    [Route("api/cities")]

    public class CitiesController : Controller
    {

        [HttpGet()]

        public JsonResult GetCities()
        {

            return new JsonResult(new List<object>()
            {
                new { id = 1 , Name =  "New York City" },
                new { id = 2, Name = "Antwerp" }
            });
        }

        [HttpGet("{id}")]

        public JsonResult GetCity(int id)
        {
            return new JsonResult
               (
                CityDataStore.Current.Cities.FirstOrDefault(c => c.Id == id)
               );
        }

    }
}
