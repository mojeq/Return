using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Return.Models.ViewModels
{
    public class AddressViewModel
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerLastName { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
