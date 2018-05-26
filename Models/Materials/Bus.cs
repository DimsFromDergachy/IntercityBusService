using System.ComponentModel.DataAnnotations.Schema;

namespace IntercityBusService.Models
{
    public class Bus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public BusType Type { get; set; }
        public string RegistrationPlate { get; set; }
        public BusState State { get; set; }
    }
}