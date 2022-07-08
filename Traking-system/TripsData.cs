using Traking_system.Models;

namespace Traking_system
{
        public class TripsData
        {
            public List<TripsDTO> Trips { get; set; }

            public TripsData()
            {
                Trips = new List<TripsDTO>()
            {
                new TripsDTO()
                {
                    Id = 1,
                    Source = "Rosario",
                    Destination = "Cañada Rosquín",
                    TripOwner = "Mateo García",
                     
                },
                new TripsDTO()
                {
                    Id=2,
                     Source = "Cañada Rosquín",
                     Destination = "Rosario",
                     TripOwner = "Mateo García",

                },
                new TripsDTO()
                {
                    Id=3,
                    Source = "Rosario",
                    Destination = "Buenos Aires",
                    TripOwner = "Mateo García",
                }
            };
            }
        }
}

