using CS270_Ver_2._0.Modules;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

namespace CS270_Ver_2._0.DataBases
{
    class JhonFK_Database
    {
        public static List<Mailing_Address> JhonFK = new List<Mailing_Address>();

        public static void InitializeJhonFK()
        {
            JhonFK.Add(new Mailing_Address("B", "0", "1", "2", "3", "4", "5", "2"));
            JhonFK.Add(new Mailing_Address("B", "3", "2", "3", "2", "3", "2", "3"));
            JhonFK.Add(new Mailing_Address("B", "2", "3", "2", "3", "2", "3", "6"));
            JhonFK.Add(new Mailing_Address("A", "0", "1", "2", "3", "4", "5", "2"));
            JhonFK.Add(new Mailing_Address("A", "3", "2", "3", "2", "3", "2", "3"));
            JhonFK.Add(new Mailing_Address("A", "2", "3", "2", "3", "2", "3", "6"));
            JhonFK.Add(new Mailing_Address("C", "0", "1", "2", "3", "4", "5", "2"));
            JhonFK.Add(new Mailing_Address("C", "3", "2", "3", "2", "3", "2", "3"));
            JhonFK.Add(new Mailing_Address("C", "2", "3", "2", "3", "2", "3", "6"));
            JhonFK.Add(new Mailing_Address("D", "0", "1", "2", "3", "4", "5", "2"));
            JhonFK.Add(new Mailing_Address("D", "3", "2", "3", "2", "3", "2", "3"));
            JhonFK.Add(new Mailing_Address("D", "2", "3", "2", "3", "2", "3", "6"));
            JhonFK.Add(new Mailing_Address("E", "0", "1", "2", "3", "4", "5", "2"));
            JhonFK.Add(new Mailing_Address("E", "3", "2", "3", "2", "3", "2", "3"));
            JhonFK.Add(new Mailing_Address("E", "2", "3", "2", "3", "2", "3", "6"));
        }

        public static void DeleteMailingAddress(int index)
        {
            JhonFK.RemoveAt(index);
        }

        public static List<TextBlock> PrintJhonFK(string companyName)
        {
            List<TextBlock> boxes = new List<TextBlock>();
            foreach (Mailing_Address txt in JhonFK)
            {
                if (companyName == txt.CompanyName)
                {
                    TextBlock box = new TextBlock();
                    box.Text = "Company Name: " + txt.CompanyName + "\n" +
                        "Street Address 1: " + txt.StreetAddress1 + "\n" +
                        "Street Address 2: " + txt.StreetAddress2 + "\n" +
                        "City: " + txt.City + "\n" +
                        "State Or Province: " + txt.StateOrProvince + "\n" +
                        "Country: " + txt.Country + "\n" +
                        "Zipcode: " + txt.Zipcode;
                    boxes.Add(box);
                } else {
                    continue;
                }
            }
            return boxes;
        }
    }
}
