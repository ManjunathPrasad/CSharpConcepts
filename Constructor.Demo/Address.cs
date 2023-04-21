using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor.Demo
{
    public class Address
    {
        public Address() { }    

        public int HouseNumber { get; set; }
        public string? StreetName { get; set; }
        public string? City { get; set; } = null;
        public string? State { get; set; } = string.Empty;
        public int PostalCode { get; set; }
        public string? Country { get; set; } 
        public int Phone { get; set; }
    }
}
