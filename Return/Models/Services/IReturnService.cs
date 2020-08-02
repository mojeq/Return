using Return.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Return.Models.Services
{
    public interface IReturnService
    {
        ReturnViewModel AddReturn(ReturnViewModel notification);

        ReturnViewModel GetReturn(int id);

        ReturnViewModel ChangeStatus(int id);

        int SaveAddress(AddressViewModel address);

        void SendNewNotificationToCustomer(int addressId);

        void SendNewNotificationToOffice(int addressId);
    }
}
