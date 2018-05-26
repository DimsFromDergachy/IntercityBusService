using System.ComponentModel.DataAnnotations.Schema;

namespace IntercityBusService.Models
{
    public class BusType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
    }
}