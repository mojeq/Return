using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Return.Models.EntityModels
{
    public class ReturnEntity
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string CustomerLastName { get; set; }
        [Required]
        public string OrderNumber { get; set; }
        [Required]
        public string DeliveryDate { get; set; }
        [Required]
        public DateTime NotificationDate { get; set; }
        [Required]
        public string BankAccount { get; set; }
        [Required]
        public int HowManyProductToReturn { get; set; }
        [Required]
        public string ProductsToReturn { get; set; }
        [Required]
        public decimal ValueToReturn { get; set; }
        public ICollection<ItemToReturnEntity> itemsToReturn { get; set; }
        public string TrackingNumber { get; set; }
    }
}
