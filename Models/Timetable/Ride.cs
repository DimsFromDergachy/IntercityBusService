namespace IntercityBusService.Models
{
    public class Ride
    {
        public int ID { get; set; }
        public Schedule Schedule { get; set; }
        public Route Route { get; set; }
        public int Cost { get; set; } // TODO: Use Currence type
        public Bus Bus { get; set; }
        public User Driver { get; set; }
    }
}