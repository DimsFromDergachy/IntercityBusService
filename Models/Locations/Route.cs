namespace IntercityBusService.Models
{
    public class Route
    {
        public int ID { get; set; }
        public Location Source { get; set; }
        public Location Destination { get; set; }
        public double Altitude { get; set; }
    }
}