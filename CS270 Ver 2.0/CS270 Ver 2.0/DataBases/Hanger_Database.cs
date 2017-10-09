using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS270_Ver_2._0.Modules;

namespace CS270_Ver_2._0.DataBases
{
    class Hanger_Database
    {
        public static List<Flight_Constructor> Hanger = new List<Flight_Constructor>();

        public static void IntializeHanger()
        {
            Hanger.Add(new Plane("N", "R", "K", "I", "J", "M", "R", "M", "P", "O", "R"));
            Hanger.Add(new Plane("M", "N", "K", "I", "J", "R", "M", "P", "O", "P", "O"));
            Hanger.Add(new Plane("O", "M", "K", "I", "J", "N", "P", "O", "R", "N", "P"));
            Hanger.Add(new Plane("P", "O", "K", "I", "J", "P", "O", "R", "N", "M", "M"));
            Hanger.Add(new Plane("R", "P", "K", "I", "J", "O", "M", "N", "M", "R", "M"));
        }

        public static void AddPlane(Flight_Constructor Plane)
        {
            Hanger.Add(Plane);
        }
    }
}
