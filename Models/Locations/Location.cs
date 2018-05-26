using System.ComponentModel.DataAnnotations.Schema;

namespace IntercityBusService.Models
{
    public class Location
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string Settlement { get; set; }
    }
}