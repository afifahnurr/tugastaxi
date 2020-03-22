using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication3
{
    class Taxi
    {
        static void Main(string[] args)
        {
            Codingan Taxi = new Codingan();
            Taxi.driverName = "Afifah";
            Taxi.onDuty = true;
            Taxi.NumPassenger = 10;

            Taxi.TaxiInfo();
            Console.WriteLine("\n");
            Taxi.PickUpPassenger();
            Taxi.DropOffPassenger();
            Console.ReadKey();
        }
    }


}



