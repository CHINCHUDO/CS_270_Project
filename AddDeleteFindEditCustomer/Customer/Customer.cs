namespace Customer
{

    public class ShippingAddress
    {
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string StateProvince { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }


        public ShippingAddress(string companyName, string contactName, string streetAddress1, string streetAddress2, string stateProvince, string city, string zipCode, string country)
        {
            CompanyName = companyName;
            ContactName = contactName;
            StreetAddress1 = streetAddress1;
            StreetAddress2 = streetAddress2;
            StateProvince = stateProvince;
            City = city;
            ZipCode = zipCode;
            Country = country;
        }
    }

    public class BillingAddress
    {
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string StateProvince { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }


        public BillingAddress(string companyName, string contactName, string streetAddress1, string streetAddress2, string stateProvince, string city, string zipCode, string country)
        {
            CompanyName = companyName;
            ContactName = contactName;
            StreetAddress1 = streetAddress1;
            StreetAddress2 = streetAddress2;
            StateProvince = stateProvince;
            City = city;
            ZipCode = zipCode;
            Country = country;
        }
    }
}