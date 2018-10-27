using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApi.Models
{
    public class CitiesDataStore
    {
        public List<City> Cities { get; set; }
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public CitiesDataStore()
        {
            Cities = new List<City>()
            {
                new City()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one with that big park.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "The most visited urban park in the United States"
                        },
                        new PointOfInterest()
                        {
                            Id = 2,
                            Name = "Empire State Building",
                            Description = "A 102-story skyscraper located in Midtown Manhatten"
                        }
                    }
                    
                },
                new City()
                {
                    Id = 2,
                    Name = "Bristol",
                    Description = "The one with that big bridge.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Id = 3,
                            Name = "Clifton Suspesion Bridge",
                            Description = "It's old, it's high. It's basically Snoop Doggy Dogg."
                        },
                        new PointOfInterest()
                        {
                            Id = 4,
                            Name = "SS Great Britain",
                            Description = "Old ass boat. What's not to love?"
                        }
                    }

                },
                new City()
                {
                    Id = 3,
                    Name = "Antwerp",
                    Description = "The one with the cathedral that was never really finished.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Id = 5,
                            Name = "Cathedral",
                            Description = "It never got finished, so apparently that is how you get famous."
                        }
                    }
                },

            };
        }

    }
}
