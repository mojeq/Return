using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Return.Models.EntityModels
{
    public class ItemToReturnEntity
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int ReturnId { get; set; }
        public ReturnEntity ReturnEntity { get; set; }
    }
}
