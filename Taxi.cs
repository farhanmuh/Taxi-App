using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiApplication
{
    public class Taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassengers { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0} ", DriverName);
            Console.WriteLine("On Duty : {0} ", OnDuty);
            Console.WriteLine("Number of Passengers : {0}", NumPassengers);
        }

        public void PickUpPassengers()
        {
            Console.WriteLine(DriverName+" sedang menjemput penumpang");
        }
        public void DropOffPassengers()
        {
            Console.WriteLine(DriverName+" selesai mengantar penumpang");
        }
    } 
}