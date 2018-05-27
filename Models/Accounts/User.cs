using System.ComponentModel.DataAnnotations.Schema;

namespace IntercityBusService.Models
{
    public enum Role
    {
        Administrator,
        Manager,
        Driver,
        Passenger,
        Guest,
    }

    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; } // TODO: Obfuscate!
        public Role Role { get; set; }
    }
}