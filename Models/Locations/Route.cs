using System.ComponentModel.DataAnnotations.Schema;

namespace IntercityBusService.Models
{
    public class Route
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public Location Source { get; set; }
        public Location Destination { get; set; }
        public double Altitude { get; set; }
    }
}