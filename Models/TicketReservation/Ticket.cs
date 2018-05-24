using System;

namespace IntercityBusService.Models
{
    public class Ticket
    {
        public int ID { get; set; }
        public User Passenger { get; set; }
        public Ride Ride { get; set; }
        public DateTime DepartmentTime { get; set; }
        public DateTime ArrivingTime { get; set; }
        public RideStatus Status { get; set; }
    }
}