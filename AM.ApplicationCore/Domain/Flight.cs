using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public int FlightId { get; set; }

        public Plane Plane { get; set; }

        public string Departure { get; set; }

        public DateTime EffictiveArrival { get; set; }

        public int EstimatedDuration { get; set; }

        public IList<Passenger> Passengers { get; set; }

        

        // constructor
        public Flight( Plane plane, string departure, DateTime effictiveArrival, int estimatedDuration,
            List<Passenger> passengers

        )
        {
            
            Plane = plane;
            Departure = departure;
            EffictiveArrival = effictiveArrival;
            EstimatedDuration = estimatedDuration;
            Passengers = passengers;
        }

        //ToString
        public override string ToString()
        {
            return $"FlightId: {FlightId}, Plane: {Plane}, Departure: {Departure}, EffictiveArrival: {EffictiveArrival}, EstimatedDuration: {EstimatedDuration}";
        }


    }
}
