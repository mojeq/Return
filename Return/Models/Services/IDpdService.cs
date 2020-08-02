using Return.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Return.Models.Services
{
    public interface IDpdService
    {
        public string GenerateWayBill(AddressEntity address);
    }
}
