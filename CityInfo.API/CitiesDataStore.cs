using CityInfo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current {get;} = new CitiesDataStore();

        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "Cluj",
                    Description = "The best",
                    PointsOfInterest = new List<PointOfInterestDto> ()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Cathedral",
                            Description = "A historical place"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Piata Unirii",
                            Description = "Beautiful place"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Bucuresti",
                    Description = "The capital of Romania",
                     PointsOfInterest = new List<PointOfInterestDto> ()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 3,
                            Name = "Central Park",
                            Description = "Good for rest"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Iasi",
                    Description = "A beautiful city"
                }
            };
        }
    }
}
