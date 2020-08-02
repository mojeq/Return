using Microsoft.AspNetCore.Mvc;
using MimeKit;
using Return.Models.EntityModels;
using Return.Models.Persistence;
using Return.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using MailKit.Net.Smtp;

namespace Return.Models.Services
{
    public partial class ReturnService : IReturnService
    {
        private readonly DateTimeNow _dateTimeNow;
        private readonly MyContex _myContex;
        private ReturnViewModel notification;
        private readonly IDpdService _dpdService;

        public ReturnService(MyContex myContex, DateTimeNow dateTimeNow)
        {
            _dateTimeNow = dateTimeNow;
            _myContex = myContex;
            notification = new ReturnViewModel();
           
        }
        public ReturnViewModel AddReturn(ReturnViewModel notification)
        {
            ReturnEntity returnEntity = new ReturnEntity()
            {              
                OrderNumber = notification.OrderNumber,
                CustomerName = notification.CustomerName,
                CustomerLastName = notification.CustomerLastName,
                BankAccount=notification.BankAccount,
                NotificationDate = _dateTimeNow.dateTime,
                DeliveryDate = notification.DeliveryDate,
                HowManyProductToReturn = 3,
                ProductsToReturn = notification.ProductsToReturn,
                ValueToReturn = notification.ValueToReturn,
                TrackingNumber = "0",
            };

            try
            {
                _myContex.Returns.Add(returnEntity);
                _myContex.SaveChanges();
            }
            catch
            {
                //return "Zapis zgłoszenia nie powiódł się";
                throw new Exception("Zapis zgłoszenia nie powiódł się");               
            }

            //return "Success";     
            return notification;
        }

        public int SaveAddress(AddressViewModel address)
        {
            AddressEntity addressEntity = new AddressEntity()
            {
                CustomerName = address.CustomerName,
                CustomerLastName = address.CustomerLastName,
                Street = address.Street,
                StreetNumber = address.StreetNumber,
                City = address.City,
                ZipCode = address.ZipCode,
                PhoneNumber = address.PhoneNumber,
                Email = address.Email,      
                ReturnId = 4,
            };

            _myContex.Addresses.Add(addressEntity);
            _myContex.SaveChanges();

            int addressId = addressEntity.AddressId;

            return addressId;
        }

        public void SendNewNotificationToCustomer(int addressId)
        {
            if (addressId == 0)
            {
                throw new Exception("Brak adresu.");
            }

            AddressEntity address = _myContex.Addresses.Find(addressId);

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("TerraSklep", "biuro@terrasklep.pl"));
            message.To.Add(new MailboxAddress(address.Email));
            message.Subject = "Nowe zgłoszenie zwrotu towaru";

            BodyBuilder message_body = new BodyBuilder();
            message_body.TextBody = "Witaj "+address.CustomerName+" "+address.CustomerLastName+" \nZgłosiłeś zwrot towaru, czekaj na dalsze instrukcje. \nPozdrawiamy\nTerraSklep";
            message.Body = message_body.ToMessageBody();

            using(var smtpClient = new SmtpClient())
            {
                MailConfig mailConfig = new MailConfig();
                smtpClient.Connect(mailConfig.Serwer, 465, true);
                smtpClient.Authenticate(mailConfig.Mail, mailConfig.Password);
                smtpClient.Send(message);
                smtpClient.Disconnect(true);
                smtpClient.Dispose();
            }
        }
      
        void IReturnService.SendNewNotificationToOffice(int addressId)
        {
            if (addressId == 0)
            {
                throw new Exception("Brak adresu.");
            }

            AddressEntity address = _myContex.Addresses.Find(addressId);

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("TerraSklep", "biuro@terrasklep.pl"));
            message.To.Add(new MailboxAddress("TerraSklep", "piotr.moj1@gmail.com"));
            message.Subject = "Nowe zgłoszenie zwrotu towaru";

            BodyBuilder message_body = new BodyBuilder();
            message_body.TextBody = "Klient " + address.CustomerName + " " + address.CustomerLastName + " zgłosił zwrot towaru. \nWygeneruj etykietę i przeslij klientowi.";
            message.Body = message_body.ToMessageBody();

            using (var smtpClient = new SmtpClient())
            {
                MailConfig mailConfig = new MailConfig();
                smtpClient.Connect(mailConfig.Serwer, 465, true);
                smtpClient.Authenticate(mailConfig.Mail, mailConfig.Password);
                smtpClient.Send(message);
                smtpClient.Disconnect(true);
                smtpClient.Dispose();
            }
        }    

        public ReturnViewModel GetReturn(int id)
        {            

            return notification;
        }

        public ReturnViewModel ChangeStatus(int id)
        {
            return notification;
        }

    }
}
