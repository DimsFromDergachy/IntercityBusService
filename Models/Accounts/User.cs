namespace IntercityBusService.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; } // TODO: Obfuscate!
        public Role Role { get; set; }
    }
}