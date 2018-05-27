using System;
using System.Collections.Generic;
using IntercityBusService.Models;

namespace IntercityBusService.Data
{
    public static class DemoData
    {
        private static User[] _users = new []
        {
            new User
            {
                ID = 0,
                Name = "admin",
                Password = "admin",
                Role = Role.Administrator,
            },
            new User
            {
                ID = 1,
                Name = "Boss",
                Password = "Boss",
                Role = Role.Manager,
            },
            new User
            {
                ID = 2,
                Name = "Manager",
                Password = "Manager",
                Role = Role.Manager,
            },
            new User
            {
                ID = 3,
                Name = "Driver A",
                Password = "Driver A",
                Role = Role.Driver,
            },
            new User
            {
                ID = 4,
                Name = "Driver B",
                Password = "Driver B",
                Role = Role.Driver,
            },
            new User
            {
                ID = 5,
                Name = "Passenger 1",
                Password = "Passenger 1",
                Role = Role.Passenger,
            },
            new User
            {
                ID = 6,
                Name = "Passenger 2",
                Password = "Passenger 2",
                Role = Role.Passenger,
            },
            new User
            {
                ID = 7,
                Name = "Passenger 3",
                Password = "Passenger 3",
                Role = Role.Passenger,
            }
        };
        private static BusType[] _busTypes = new []
        {
            new BusType
            {
                ID = 0,
                Description = "Combination bus",
                Capacity = 12,
            },
            new BusType
            {
                ID = 1,
                Description = "Rigid bus",
                Capacity = 41,
            },
            new BusType
            {
                ID = 2,
                Description = "Gyrobus",
                Capacity = 24,
            },
            new BusType
            {
                ID = 3,
                Description = "Kid hack",
                Capacity = 12,
            },
            new BusType
            {
                ID = 4,
                Description = "Party bus",
                Capacity = 10,
            },
            new BusType
            {
                ID = 5,
                Description = "Bicycle bus",
                Capacity = 8,
            },
        };
        private static Bus[] _buses = new []
        {
            new Bus
            {
                ID = 0,
                BusType = _busTypes[0],
                RegistrationPlate = "AAA5176",
                State = BusState.Restored,
            },
            new Bus
            {
                ID = 1,
                BusType = _busTypes[5],
                RegistrationPlate = "XKCD1392",
                State = BusState.New,
            },
            new Bus
            {
                ID = 2,
                BusType = _busTypes[5],
                RegistrationPlate = "GIFT32",
                State = BusState.Restored,
            },
            new Bus
            {
                ID = 3,
                BusType = _busTypes[5],
                RegistrationPlate = "KISS999",
                State = BusState.Broken,
            },
        };
        private static Location[] _locations = new []
        {
            new Location { ID = 0, Settlement = "Gotham City"  },
            new Location { ID = 1, Settlement = "Zion"         },
            new Location { ID = 2, Settlement = "Emerald City" },
            new Location { ID = 3, Settlement = "Toontown"     },
            new Location { ID = 4, Settlement = "Seabrook"     },
            new Location { ID = 5, Settlement = "Castle Rock"  },
            new Location { ID = 6, Settlement = "Los Santos"   },
            new Location { ID = 7, Settlement = "Waterdeep"    },
        };
        private static Route[] _routes = new []
        {
            new Route
            {
                ID = 2,
                Source = _locations[1],
                Destination = _locations[2],
                Altitude = 1023,
            },
            new Route
            {
                ID = 3,
                Source = _locations[1],
                Destination = _locations[3],
                Altitude = 341,
            },
            new Route
            {
                ID = 4,
                Source = _locations[1],
                Destination = _locations[0],
                Altitude = 54,
            },
            new Route
            {
                ID = 5,
                Source = _locations[0],
                Destination = _locations[3],
                Altitude = 77,
            },
            new Route
            {
                ID = 6,
                Source = _locations[3],
                Destination = _locations[1],
                Altitude = 444,
            },
            new Route
            {
                ID = 7,
                Source = _locations[3],
                Destination = _locations[5],
                Altitude = 63,
            },
            new Route
            {
                ID = 8,
                Source = _locations[3],
                Destination = _locations[6],
                Altitude = 99,
            },
            new Route
            {
                ID = 9,
                Source = _locations[5],
                Destination = _locations[0],
                Altitude = 555,
            },
            new Route
            {
                ID = 10,
                Source = _locations[5],
                Destination = _locations[6],
                Altitude = 5,
            },
        };
        private static Schedule[] _schedules = new []
        {
            new Schedule
            {
                ID = 0,
                DaysPattern = RepeatDaysPattern.EveryDay,
                Time = DateTime.Parse("08:10:00"),
            },
            new Schedule
            {
                ID = 1,
                DaysPattern = RepeatDaysPattern.Evens,
                Time = DateTime.Parse("13:30:00"),
            },
            new Schedule
            {
                ID = 2,
                DaysPattern = RepeatDaysPattern.Odds,
                Time = DateTime.Parse("15:40:00"),
            }
        };
        private static Ride[] _rides = new []
        {
            new Ride
            {
                ID = 1,
                Schedule = _schedules[1],
                Route = _routes[2],
                Cost = 140,
                Bus = _buses[0],
                Driver = _users[4],
            },
            new Ride
            {
                ID = 2,
                Schedule = _schedules[1],
                Route = _routes[5],
                Cost = 255,
                Bus = _buses[0],
                Driver = _users[5],
            },
            new Ride
            {
                ID = 3,
                Schedule = _schedules[2],
                Route = _routes[3],
                Cost = 13,
                Bus = _buses[3],
                Driver = _users[4],
            },
        };
        private static Ticket[] _tickets = new []
        {
            new Ticket
            {
                ID = 0,
                Passenger = _users[7],
                Ride = _rides[2],
                DepartmentTime = DateTime.Parse("09.14.2016 08:10:00"),
                ArrivingTime = DateTime.Parse("09.14.2016 09:25:00"),
                Status = RideStatus.Success,
            },
        };

        public static IEnumerable<User> Users => _users;
        public static IEnumerable<Bus> Buses => _buses;
        public static IEnumerable<Ride> Rides => _rides;
        public static IEnumerable<Ticket> Tickets => _tickets;
    }
}