using System.Collections.Generic;
using MySqlConnector;

namespace HairSalon.Models
{
    public class Client
    {
        public string PhoneNumber { get; set; }
        public int ClientId { get; set; }
        public int StylistId { get; set; }
        public Stylist Stylist { get; set; }
    }
}