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

        SearchCustomer.ShippingAddress objTextBox = (StreetAddress1)sender;
        ShippingAddress shippingAddress = new ShippingAddress(StreetAddress1.value, string ContactName,);

        public static object StreetAddress2 { get; private set; }

        private void CumstomerSearchButton_Click(object sender, RoutedEventArgs e)
        {
           
            
            //Search both BillingAddresses and ShippingAddresses
            this.Frame.Navigate(typeof(CustomerSearch));


        }

        private void addCustomerButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }

}




