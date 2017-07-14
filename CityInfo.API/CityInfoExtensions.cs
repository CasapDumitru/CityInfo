using CityInfo.API.Entities;
using CityInfo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public static class CityInfoExtensions
    {
        public static void EnsureSeedDataForContext(this CityInfoContext context)
        {
            if(context.Cities.Any())
            {
                return;
            }
            var Cities = new List<City>()
            {
                new City()
                {
                    Name = "Cluj",
                    Description = "The best",
                    PointsOfInterest = new List<PointOfInterest> ()
                    {
                        new PointOfInterest()
                        {
                            Name = "Cathedral",
                            Description = "A historical place"
                        },
                        new PointOfInterest()
                        {
                            Name = "Piata Unirii",
                            Description = "Beautiful place"
                        }
                    }
                },
                new City()
                {
                    Name = "Bucuresti",
                    Description = "The capital of Romania",
                     PointsOfInterest = new List<PointOfInterest> ()
                    {
                        new PointOfInterest()
                        {
                            Name = "Central Park",
                            Description = "Good for rest"
                        }
                    }
                },
                new City()
                {
                    Name = "Iasi",
                    Description = "A beautiful city"
                }
            };

            context.Cities.AddRange(Cities);
            context.SaveChanges();
        }
    }
}
