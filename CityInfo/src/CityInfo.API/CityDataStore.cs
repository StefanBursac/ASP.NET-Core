using CityInfo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class CityDataStore
    {
        public static CityDataStore Current { get; } = new CityDataStore();

        public List<CityDto> Cities { get; set; }
        
        public CityDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The One with that big park"
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "The One  with catedral that was never finished"
                }
            };
        }
    }
}
