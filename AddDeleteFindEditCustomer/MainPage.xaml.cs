using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AddDeleteFindEditCustomer
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void isPOBox_Checked(object sender, RoutedEventArgs e)
        {
            // Search only billing addresses since we do not deleiver to P.O. Boxes


        }

        private void CumstomerSearchButton_Click(object sender, RoutedEventArgs e)
        {
            //Search both BillingAddresses and ShippingAddresses
            this.Frame.Navigate(typeof(CustomerSearch));


        }

    }

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

        //private void buttonAction_Click()
        //{
        //    this.Frame.Navigate(typeof(CustomerSearch));
        //}
    }
}
