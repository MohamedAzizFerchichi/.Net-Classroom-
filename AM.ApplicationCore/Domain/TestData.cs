



using System;
using System.Collections.Generic;


namespace AM.ApplicationCore.Domain

{
    public static class TestData
    {

        public static List<Passenger> Travellers = new List<Passenger>
        {
            new Traveller
            {
                FirstName = "Traveller1",
                LastName = "Traveller1",
                EmailAdresse = "Traveller1.Traveller1@gmail.com",
                BirthDate = new DateTime(1980, 1, 1),
                HealthInfomation = "No troubles",
                Nationality = "American"
            },
            new Traveller
            {
                FirstName = "Traveller2",
                LastName = "Traveller2",
                EmailAdresse = "Traveller2.Traveller2@gmail.com",
                BirthDate = new DateTime(1981, 1, 1),
                HealthInfomation = "Some troubles",
                Nationality = "French"
            },
            new Traveller
            {
                FirstName = "Traveller3",
                LastName = "Traveller3",
                EmailAdresse = "Traveller3.Traveller3@gmail.com",
                BirthDate = new DateTime(1982, 1, 1),
                HealthInfomation = "No troubles",
                Nationality = "Tunisian"
            },
            new Traveller
            {
                FirstName = "Traveller4",
                LastName = "Traveller4",
                EmailAdresse = "Traveller4.Traveller4@gmail.com",
                BirthDate = new DateTime(1983, 1, 1),
                HealthInfomation = "Some troubles",
                Nationality = "American"
            },
            new Traveller
            {
                FirstName = "Traveller5",
                LastName = "Traveller5",
                EmailAdresse = "Traveller5.Traveller5@gmail.com",
                BirthDate = new DateTime(1984, 1, 1),
                HealthInfomation = "Some troubles",
                Nationality = "Spanish"
            }
        };

        public static List<Staff> StaffMembers = new List<Staff>
        {
            new Staff
            {
                FirstName = "captain",
                LastName = "captain",
                EmailAdresse = "Captain.captain@gmail.com",
                BirthDate = new DateTime(1965, 1, 1),
                EmploymentDate = new DateTime(1999, 1, 1),
                Salary = 99999
            },
            new Staff
            {
                FirstName = "hostess1",
                LastName = "hostess1",
                EmailAdresse = "hostess1.hostess1@gmail.com",
                BirthDate = new DateTime(1995, 1, 1),
                EmploymentDate = new DateTime(2020, 1, 1),
                Salary = 999
            },
            new Staff
            {
                FirstName = "hostess2",
                LastName = "hostess2",
                EmailAdresse = "hostess2.hostess2@gmail.com",
                BirthDate = new DateTime(1996, 1, 1),
                EmploymentDate = new DateTime(2020, 1, 1),
                Salary = 999
            }
        };

        public static List<Plane> listPlanes = new List<Plane>
        {
            new Plane(PlaneType.Boing, 150, DateTime.Parse("03/02/2015")),
            new Plane(PlaneType.Airbus, 250, DateTime.Parse("11/11/2020"))
        };

        public static List<Flight> listFlights = new List<Flight>
        {
            new Flight(listPlanes[1], "Paris", new DateTime(2022, 1, 1, 17, 10, 10),110,Travellers),
            new Flight(listPlanes[0], "Paris", new DateTime(2022, 2, 1, 23, 10, 10), 105, null),
            new Flight(listPlanes[0], "Paris", new DateTime(2022, 3, 1, 6, 40, 10), 100, null),
            new Flight(listPlanes[0], "Madrid", new DateTime(2022, 4, 1, 8, 10, 10), 130, null),
            new Flight(listPlanes[0], "Madrid", new DateTime(2022, 5, 1, 18, 50, 10), 105, null),
            new Flight(listPlanes[1], "Lisbonne", new DateTime(2022, 6, 1, 22, 30, 10), 200, null)
        }; 




       


    }
}