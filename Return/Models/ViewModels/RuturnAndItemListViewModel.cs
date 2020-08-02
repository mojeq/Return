using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Return.Models.ViewModels
{
    public class RuturnAndItemListViewModel
    {
        public ReturnViewModel ReturnData { get; set; }
        public IList<ItemToReturnViewModel> ItemsToReturn { get; set; }
    }
}
