﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; } 
        public string? Email { get; set; }
        public string? Gender { get; set; }
        public string? RG { get; set; }
        public string? CPF { get; set; }
        public string? MotherName { get; set; }
        public string? RegistrationStatus { get; set; }
        public DateTime CreatedAt { get; set; }
        public Contact? Contact { get; set; }  
        public ICollection<DeliveryAdress>? DeliveryAdresses { get; set; }
        public ICollection<Department>? Departments { get; set; }
    }
}
