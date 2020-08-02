using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Return.Models.ViewModels
{
    public class ReturnViewModel
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerLastName { get; set; }
        public string OrderNumber { get; set; }
        public string DeliveryDate { get; set; }
        public DateTime NotificationDate { get; set; }
        public string BankAccount { get; set; }
        public int HowManyProductToReturn { get; set; }
        public string ProductsToReturn { get; set; }
        public decimal ValueToReturn { get; set; }
        public ICollection<ItemToReturnViewModel> itemsToReturn { get; set; }
        public string TrackingNumber { get; set; }
    }
}
