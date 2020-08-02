using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Return.Models.EntityModels;

namespace Return.Models.Services
{
    public class DpdService : IDpdService
    {
        public string GenerateWayBill(AddressEntity address)
        {
            //            DPDPackageObjServicesClient sp = new DPDPackageObjServicesClient();
            //            authDataV1 authData = getAuth();

            //            generatePackagesNumber(sp, authData);


            //            // walidacja danych przesyłek i nadawanie numerów listów przewozowych
            //            int FID = 1495;
            //            packageOpenUMLFeV1[] umlf = new packageOpenUMLFeV1[1]; //ile przesyłek
            //            packageOpenUMLFeV1 pkg = new packageOpenUMLFeV1();
            //            pkg.parcels = new parcelOpenUMLFeV1[2]; //ile paczek
            //            pkg.payerType = payerTypeEnumOpenUMLFeV1.SENDER;
            //            pkg.payerTypeSpecified = true;
            //            pkg.thirdPartyFIDSpecified = true;

            //            packageAddressOpenUMLFeV1 addressSender = new packageAddressOpenUMLFeV1();
            //            addressSender.address = "Bzinica Stara ul. Miarki 1";
            //            addressSender.city = "Dobrodzień";
            //            addressSender.company = "TerraSklep";
            //            addressSender.countryCode = "PL";
            //            addressSender.email = "biuro@terrasklep.pl";
            //            addressSender.fidSpecified = true;
            //            addressSender.fid = FID;
            //            addressSender.name = "Piotr Moj";
            //            addressSender.phone = "790369790";
            //            addressSender.postalCode = "46380";
            //            pkg.sender = addressSender;

            //            packageAddressOpenUMLFeV1 addressReceiver = new packageAddressOpenUMLFeV1();
            //            addressReceiver.address = address.Street + " " + address.StreetNumber;
            //            addressReceiver.city = address.City;
            //            addressReceiver.company = " ";
            //            addressReceiver.countryCode = "PL";
            //            addressReceiver.email = address.Email;
            //            addressReceiver.fidSpecified = true;
            //            addressReceiver.name = address.CustomerName + " " + address.CustomerLastName;
            //            addressReceiver.phone = address.PhoneNumber;
            //            addressReceiver.postalCode = address.ZipCode;
            //            pkg.receiver = addressReceiver;
            //            pkg.ref1 = "1234567890";
            //            pkg.ref2 = "abcdefgh";
            //            pkg.ref3 = "ZZZZZZZZZ";

            //            parcelOpenUMLFeV1 parcel = new parcelOpenUMLFeV1();
            //            parcel.sizeX = 30;
            //            parcel.sizeY = 40;
            //            parcel.sizeZ = 40;
            //            parcel.content = "Zwrot towaru";
            //            parcel.customerData1 = address.CustomerName + " " + address.CustomerLastName;
            //            parcel.weight = 5;

            //            pkg.parcels[0] = parcel;

            //            umlf[0] = pkg;

            //           // packagesGenerationResponseV2 documentGenerationResponse = sp.generatePackagesNumbersV4Async(umlf, pkgNumsGenerationPolicyV1.IGNORE_ERRORS, "PL", authData);



            //            string xmlRequest = @"<S:Envelope xmlns:S = ""http://schemas.xmlsoap.org/soap/envelope/"">
            //                                 <S:Header/>
            //                                  <S:Body>
            //                                   <ns2:findPostalCodeV1 xmlns:ns2 = ""http://dpdservices.dpd.com.pl/"">
            //                                    <postalCodeV1>
            //                                    <countryCode>PL</countryCode>
            //                                    <zipCode>02275</zipCode>
            //                                    </postalCodeV1>
            //                                    <authDataV1>
            //                                    <login>userlogin</login>
            //                                    <masterFid>999</masterFid>
            //                                    <password> xxxxxxxxx </password>
            //                                    </authDataV1>
            //                                    </ns2:findPostalCodeV1>
            //                                     </S:Body>
            //                                      </S:Envelope>";

            //            //var resultCheckPostalCode = DeserializeXmlResponse(SendSoap(xmlRequest, ZipCode));

            string resultCheckPostalCode = "ok";
            return resultCheckPostalCode;
        }

        //        private static authDataV1 getAuth()
        //        {
        //            authDataV1 auth = new authDataV1();
        //            auth.login = "pmarat";
        //            auth.password = "pm14";
        //            auth.masterFid = 1465;
        //            return auth;
        //        }

        //        private static void generatePackagesNumber(DPDPackageObjServicesClient sp, authDataV1 authData)
        //        {
        //            long sessionId;
        //            long packageId;

        //            packageOpenUMLFeV3[] umlf = new packageOpenUMLFeV3[1]; // Ilość przesyłek
        //            packageOpenUMLFeV3 pkg = new packageOpenUMLFeV3();
        //            pkg.parcels = new parcelOpenUMLFeV1[1]; //Paczek w przesyłce
        //            pkg.payerType = payerTypeEnumOpenUMLFeV1.SENDER;
        //            pkg.payerTypeSpecified = true;

        //            packageAddressOpenUMLFeV1 addressSender = new packageAddressOpenUMLFeV1();
        //            addressSender.address = "Ul. Mineralna 15";
        //            addressSender.city = "Warszawa";
        //            addressSender.company = "DPD Polska Sp. z o.o.";
        //            addressSender.countryCode = "PL";
        //            addressSender.email = "dpd@com.pl";
        //            addressSender.fidSpecified = true;
        //            addressSender.fid = 1495;
        //            addressSender.name = "Jan Kowalski";
        //            addressSender.phone = "022 577 55 00";
        //            addressSender.postalCode = "02274";
        //            pkg.sender = addressSender;

        //            packageAddressOpenUMLFeV1 addressReceiver = new packageAddressOpenUMLFeV1();
        //            addressReceiver.address = "ul. Brzeziñska 59";
        //            addressReceiver.city = "Mysłowice";
        //            addressReceiver.company = "Oddział Regionalny w Katowicach";
        //            addressReceiver.countryCode = "PL";
        //            addressReceiver.email = "dpd@com.pl";
        //            addressReceiver.fidSpecified = true;
        //            addressReceiver.name = "Jan Malinowski";
        //            addressReceiver.phone = "32 202-40-11";
        //            addressReceiver.postalCode = "41404";
        //            pkg.receiver = addressReceiver;
        //            pkg.ref1 = "5h163K1";
        //            pkg.ref2 = "FV/2017/12/1234";
        //            pkg.ref3 = "";

        //            servicesOpenUMLFeV4 services = new servicesOpenUMLFeV4();
        //            //serviceCODOpenUMLFeV1 cod = new serviceCODOpenUMLFeV1();
        //            //cod.amount = "1234";
        //            //cod.currency = serviceCurrencyEnum.PLN;
        //            //cod.currencySpecified = true;
        //            //services.cod = cod;

        //            serviceRODOpenUMLFeV1 rod = new serviceRODOpenUMLFeV1();
        //            services.rod = rod;

        //            pkg.services = services;

        //            parcelOpenUMLFeV1 parcel1 = new parcelOpenUMLFeV1();
        //            //parcel1.sizeXSpecified = true;
        //            parcel1.sizeX = 30;
        //            //parcel1.sizeYSpecified = true;
        //            parcel1.sizeY = 40;
        //            //parcel1.sizeZSpecified = true;
        //            parcel1.sizeZ = 30;
        //            //parcel1.weightSpecified = true;
        //            parcel1.content = "Towar do zwrotu";
        //            parcel1.customerData1 = "zwrot";
        //            //parcel1.reference = "Nr kl. 00123456"; //parametr opcjonalny
        //            parcel1.weight = 5;

        //            pkg.parcels[0] = parcel1;

        //            //parcelOpenUMLFeV1 parcel2 = new parcelOpenUMLFeV1();
        //            //parcel2.sizeXSpecified = true;
        //            //parcel2.sizeYSpecified = true;
        //            //parcel2.sizeZSpecified = true;
        //            //parcel2.weightSpecified = true;
        //            //parcel2.content = "Umowa";
        //            //parcel2.customerData1 = "Nr kl. 001234";
        //            //parcel2.reference = "Umowa nr 45762456"; //parametr opcjonalny
        //            //parcel2.weight = 0.1;

        //            //pkg.parcels[1] = parcel2;

        //            umlf[0] = pkg;

        //            packagesGenerationResponseV2 documentGenerationResponse = sp.generatePackagesNumbersV4(umlf, pkgNumsGenerationPolicyV1.IGNORE_ERRORS, "PL", authData);


        //            // interpretacja wyniku
        //            sessionId = documentGenerationResponse.SessionId;
        //            packageId = documentGenerationResponse.Packages[0].PackageId;

        //            String waybill = documentGenerationResponse.Packages[0].Parcels[1].Waybill;
        //            String umlfStatus = documentGenerationResponse.Status.ToString(); // status ca³ej sesji

        //            Console.WriteLine("Status sesji: " + umlfStatus);
        //            // statusy poszczególnych 
        //            foreach (packagePGRV2 pkgs in documentGenerationResponse.Packages)
        //            {
        //                Console.WriteLine("Status package: " + pkgs.Status.ToString());
        //                foreach (parcelPGRV2 parcel in pkgs.Parcels)
        //                {
        //                    Console.WriteLine("Status parcel: " + parcel.Status.ToString());
        //                }
        //            }
        //        }

        //        private object SendSoap(string xmlRequest, string zipCode)
        //        {
        //            throw new NotImplementedException();
        //        }
    }
}
