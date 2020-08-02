using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Return.Models.Services;
using Return.Models.ViewModels;

namespace Return.Controllers
{
    public class HomeController : Controller
    {
        private readonly IReturnService _returnService;
        public HomeController(IReturnService returnService)
        {
            _returnService = returnService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        //[HttpGet]
        //public IActionResult NewReturnStart()
        //{
        //    return View();
        //}

        [HttpPost]
        public IActionResult AddNewReturn(ReturnViewModel newReturn)
        {
            if (newReturn == null)
            {
                return BadRequest();
            }

            var result = _returnService.AddReturn(newReturn);

            if (result != null)
            //if (result == "Success")
            {
                //return RedirectToAction("NewReturnStep2", result);
                return View("NewReturnStep2", result);
            }

            return BadRequest();
        }

        public IActionResult NewReturnStep2(ReturnViewModel newReturn)
        {
            return View(newReturn);
        }

        [HttpPost]
        public IActionResult AddAddressAndSendNotification(AddressViewModel address)
        {
            if (address == null)
            {
                return BadRequest();
            }

            int addressId;
            try
            {
                addressId = _returnService.SaveAddress(address);
            }
            catch
            {
                throw new Exception("Zapis adresu nie powiódł się");
            }

            try
            {
                _returnService.SendNewNotificationToCustomer(addressId);
            }
            catch
            {
                throw new Exception("Błąd serwisu, nie wysłano maila.");
            }

            try
            {
                _returnService.SendNewNotificationToOffice(addressId);
            }
            catch
            {
                throw new Exception("Błąd serwisu, nie wysłano maila.");
            }

            return View("NewReturnComplete");
        }
    }
}
