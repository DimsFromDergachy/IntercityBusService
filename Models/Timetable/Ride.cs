using System.ComponentModel.DataAnnotations.Schema;

namespace IntercityBusService.Models
{
    public class Ride
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public Schedule Schedule { get; set; }
        public Route Route { get; set; }
        public int Cost { get; set; } // TODO: Use Currence type
        public Bus Bus { get; set; }
        public User Driver { get; set; }
    }
}