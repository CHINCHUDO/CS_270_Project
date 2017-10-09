using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS270_Ver_2._0.Modules;

namespace CS270_Ver_2._0.DataBases
{
    class Aerial_Database
    {
        public static List<Customer_Constructor> Aerial_Master = new List<Customer_Constructor>();

        public static void IntitializeMasterAerial()
        {
            Aerial_Master.Add(new Master_Adress("B", new Billing_Address("B", "D", "A", "C", "A", "A", "B", "D"), new Mailing_Address("B", "O", "A", "C", "A", "A", "B", "D")));
            Aerial_Master.Add(new Master_Adress("D", new Billing_Address("D", "P", "D", "A", "C", "B", "D", "B"), new Mailing_Address("D", "B", "D", "A", "C", "B", "D", "B")));
            Aerial_Master.Add(new Master_Adress("A", new Billing_Address("A", "Q", "B", "D", "B", "D", "A", "C"), new Mailing_Address("A", "C", "B", "D", "B", "D", "A", "C")));
            Aerial_Master.Add(new Master_Adress("C", new Billing_Address("C", "M", "A", "B", "D", "A", "C", "A"), new Mailing_Address("C", "A", "A", "B", "D", "A", "C", "A")));
            Aerial_Master.Add(new Master_Adress("E", new Billing_Address("E", "N", "A", "B", "D", "A", "C", "A"), new Mailing_Address("E", "A", "A", "B", "D", "A", "C", "A")));
        }

        public static void DeleteCustomer(int index)
        {
            Aerial_Master.RemoveAt(index);
        }     
    }
}