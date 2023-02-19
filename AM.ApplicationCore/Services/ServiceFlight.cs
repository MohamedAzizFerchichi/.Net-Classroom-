using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight : IServiceFlight
    {
        public List<Flight> Flights { get; set; }

        public ServiceFlight()
        {
            Flights = TestData.listFlights;
        }

        // with for 
        //public List<DateTime> GetFlightDates(string destination)
        //{
        //    List<DateTime> dates = new List<DateTime>();

        //    for (int i = 0; i < Flights.Count; i++)
        //    {
        //        if (Flights[i].Departure == destination)
        //        {
        //            dates.Add(Flights[i].EffictiveArrival);
        //        }
        //    }

        //    return dates;
        //}
        public List<DateTime> GetFlightDates(string destination)
        {
            List<DateTime> dates = new List<DateTime>();

            foreach (Flight flight in Flights)
            {
                if (flight.Departure == destination)
                {
                    dates.Add(flight.EffictiveArrival);
                }
            }

            return dates;
        }


        public List<Flight> GetFlights(string filterType, string filterValue)
        {   
            List<Flight> flights = new List<Flight>();

            if (filterType == "Departure")
            {
                foreach (Flight flight in Flights)
                {
                    if (flight.Departure == filterValue)
                    {
                        flights.Add(flight);
                    }
                }
            }
            else if (filterType == "Plane")
            {
                foreach (Flight flight in Flights)
                {
                    if (flight.Plane.Plane_Type.ToString() == filterValue)
                    {
                        flights.Add(flight);
                    }
                }
            }
            else if (filterType == "Date")
            {
                foreach (Flight flight in Flights)
                {
                    if (flight.EffictiveArrival.ToString() == filterValue)
                    {
                        flights.Add(flight);
                    }
                }
            }

            return flights;
        }








    }
}
    