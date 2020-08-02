using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Return.Models.EntityModels
{
    public class AddressEntity
    {
        [Key]
        [Required]
        public int AddressId { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string CustomerLastName { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string StreetNumber { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string ZipCode { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int ReturnId { get; set; }
        public ReturnEntity Return { get; set; }
    }
}
