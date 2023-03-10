using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight:IServiceFlight
    {
        public List<Flight> Flights { get; set; }=new List<Flight>();
        
        public List<DateTime> GetFlightDates(string destination)
        {
            //List<DateTime> dates = new List<DateTime>();
            //for(int i = 0; i < Flights.Count; i++)
            //{
            //    if (Flights[i].Destination==destination)
            //        dates.Add(Flights[i].FlightDate);
            //}
            //return dates;
            List<DateTime> dates = new List<DateTime>();
            foreach (var flight in Flights)
            {
                if (flight.Destination==destination)
                {
                    dates.Add(flight.FlightDate);
                }
               
            }
            return dates;
        }
        public void GetFlights(String filterType, string filterValue)
        {
            switch (filterType)
            {
                case "Destination":
                    foreach (Flight flight in Flights)
                    {
                        if (flight.Destination.Equals(filterValue))
                        {
                            System.Console.WriteLine(flight);
                        }
                    }
                    break;
                case "Date":
                    foreach (Flight flight in Flights)
                    {
                        if (flight.FlightDate.Equals(DateTime.Parse(filterValue)))
                        {
                            System.Console.WriteLine(flight);
                        }
                    }
                    break;
                case "Duration":
                    foreach (Flight flight in Flights)
                    {
                        if (flight.EstimatedDuration.Equals(int.Parse(filterValue)))
                        {
                            System.Console.WriteLine(flight);
                        }
                    }
                    break;

            }

        }

    }
}
