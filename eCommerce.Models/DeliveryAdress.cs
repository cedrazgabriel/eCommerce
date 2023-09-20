using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Models
{
    public class DeliveryAdress
    {
        public int Id { get; set; }
        public int userId { get; set; }
        public string? AdressName { get; set; }
        public string? CEP { get; set; }
        public string? State { get; set; }
        public string? City { get; set; }
        public string? Neighborhood { get; set; }
        public string? Street { get; set; }
        public string? Number { get; set; }
        public string? Complement { get; set; }
        public User? User { get; set; }
    }
}
