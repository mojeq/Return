using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Return.Models.ViewModels
{
    public class ItemToReturnViewModel
    {
        public int Id { get; set; }
        public int ReturnId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
