using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();

            taxi.DriverName = "Jono";
            taxi.OnDuty = true;
            taxi.NumPassengers = 10;

            taxi.TaxiInfo();
            taxi.PickUpPassengers();
            taxi.DropOffPassengers();

            Console.ReadKey();
        }
    }
}
