using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS270_Ver_2._0.Modules;
using Windows.UI.Xaml.Controls;

namespace CS270_Ver_2._0.DataBases
{
    class Aerial_Database
    {
        public static List<Customer_Constructor> Aerial_Master = new List<Customer_Constructor>();

        public static void IntitializeMasterAerial()
        {
            Aerial_Master.Add(new Billing_Address("B", "D", "A", "C", "A", "A", "B", "D"));
            Aerial_Master.Add(new Billing_Address("D", "P", "D", "A", "C", "B", "D", "B"));
            Aerial_Master.Add(new Billing_Address("A", "Q", "B", "D", "B", "D", "A", "C"));
            Aerial_Master.Add(new Billing_Address("C", "M", "A", "B", "D", "A", "C", "A"));
            Aerial_Master.Add(new Billing_Address("E", "N", "A", "B", "D", "A", "C", "A"));
        }

        public static void DeleteCustomer(int index)
        {
            Aerial_Master.RemoveAt(index);
        }

        public static List<TextBlock> PrintAerial()
        {
            List<TextBlock> boxes = new List<TextBlock>();
            foreach(Billing_Address txt in Aerial_Master)
            {
                TextBlock box = new TextBlock();
                box.Text = "Company Name: " + txt.CompanyName + "\n" +
                    "Street Address 1: " + txt.StreetAddress1 + "\n" + 
                    "Street Address 2: " + txt.StreetAddress2 + "\n" +
                    "City: " + txt.City + "\n" +
                    "State Or Province: " + txt.StateOrProvince + "\n" +                    
                    "Country: " + txt.Country + "\n" +
                    "Zipcode: " + txt.Zipcode;
                box.Name = txt.CompanyName;
                boxes.Add(box);
            }
            return boxes;
        }
    }
}