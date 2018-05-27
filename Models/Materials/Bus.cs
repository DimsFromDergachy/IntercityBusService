using System.ComponentModel.DataAnnotations.Schema;

namespace IntercityBusService.Models
{
    public enum BusState
    {
        New,
        Restored,
        Broken,
    }
    
    public class Bus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public BusType BusType { get; set; }
        public string RegistrationPlate { get; set; }
        public BusState State { get; set; }
    }
}