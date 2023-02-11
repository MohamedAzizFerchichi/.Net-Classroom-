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

        public Flight()
        {
            Passengers = new List<Passenger>();
        }

        //ToString
        public override string ToString()
        {
            return $"FlightId: {FlightId}, Plane: {Plane}, Departure: {Departure}, EffictiveArrival: {EffictiveArrival}, EstimatedDuration: {EstimatedDuration}";
        }
    }
}
