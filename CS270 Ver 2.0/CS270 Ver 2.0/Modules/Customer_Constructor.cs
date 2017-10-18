using CS270_Ver_2._0.DataBases;
using System.Collections.Generic;

namespace CS270_Ver_2._0.Modules
{
    class Customer_Constructor
    {
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string StateOrProvince { get; set; }
        public string Country { get; set; }
        public string Zipcode { get; set; }
        public Billing_Address Billing = null;

        public static void AddCustomer(string companyname, string contactname, string streetaddress1, string streetaddress2,
            string stateorprovince, string city, string country, string zipcode)
        {
            Aerial_Database.Aerial_Master.Add(new Billing_Address(companyname, contactname, streetaddress1, streetaddress2, stateorprovince,
                city, country, zipcode));
        }

        public static void EditBillingAddress(int index, Billing_Address newBillAdd)
        {
            Aerial_Database.Aerial_Master[index].Billing.CompanyName = newBillAdd.CompanyName;
            Aerial_Database.Aerial_Master[index].Billing.ContactName = newBillAdd.ContactName;
            Aerial_Database.Aerial_Master[index].Billing.StreetAddress1 = newBillAdd.StreetAddress1;
            Aerial_Database.Aerial_Master[index].Billing.StreetAddress2 = newBillAdd.StreetAddress2;
            Aerial_Database.Aerial_Master[index].Billing.City = newBillAdd.City;
            Aerial_Database.Aerial_Master[index].Billing.StateOrProvince = newBillAdd.StateOrProvince;
            Aerial_Database.Aerial_Master[index].Billing.Country = newBillAdd.Country;
            Aerial_Database.Aerial_Master[index].Billing.Zipcode = newBillAdd.Zipcode;
        }
    }

    class Billing_Address : Customer_Constructor
    {
        public Billing_Address(string companyname, string contactname, string streetaddress1, string streetaddress2,
            string stateorprovince, string city, string country, string zipcode)
        {
            CompanyName = companyname;
            ContactName = contactname;
            StreetAddress1 = streetaddress1;
            StreetAddress2 = streetaddress2;
            City = city;
            StateOrProvince = stateorprovince;
            Country = country;
            Zipcode = zipcode;
        }       
    }

    class Mailing_Address : Customer_Constructor
    {
        public Mailing_Address(string companyname, string contactname, string streetaddress1, string streetaddress2,
            string stateorprovince, string city, string country, string zipcode)
        {
            CompanyName = companyname;
            ContactName = contactname;
            StreetAddress1 = streetaddress1;
            StreetAddress2 = streetaddress2;
            City = city;
            StateOrProvince = stateorprovince;
            Country = country;
            Zipcode = zipcode;
        }       
    }
}