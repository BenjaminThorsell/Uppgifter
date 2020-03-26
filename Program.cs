using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilSortering
{
    class Program
    {
        static void PrintList(List<Car> listToPrint)
        {
            foreach (Car c in listToPrint)
            {
                Console.WriteLine("[Brand:] " + c.brand + " [Model:] " + c.model + " [Year:] " + c.year);
            }
        }

        static void Main(string[] args)
        {
            Car CarA = new Car("Volvo", "XC90", 2020);
            Car CarB = new Car("Mazda", "626", 1960); 
            Car CarC = new Car("Saab", "93", 1999);
            Car CarD = new Car("Porsche", "911", 2012);

            List<Car> CarList = new List<Car>();
            CarList.Add(CarA);
            CarList.Add(CarB);
            CarList.Add(CarC);
            CarList.Add(CarD);

            Console.WriteLine("Skriver ut osorterad lista...");
            Console.WriteLine("");
            PrintList(CarList);
            Console.WriteLine("");

            Console.WriteLine("Sorterar listan baserat på årsmodell...");
            CarList.Sort();
            Console.WriteLine("...klarsorterad\n");

            Console.WriteLine("Skriver ut sorterad lista baserat på årsmodell...");
            Console.WriteLine("");
            PrintList(CarList);
            Console.WriteLine("");




            
            if (CarA > CarB)
            {
                Console.WriteLine("");
            }
            else if (CarA < CarB)
            {
                Console.WriteLine("");
            }

            if (CarA == CarB)
            {
                Console.WriteLine("");
            }

            if (CarA == CarD)
            {
                Console.WriteLine("");
            }

            if (CarB != CarC)
            {
                Console.WriteLine("");
            }


            
            var watch = System.Diagnostics.Stopwatch.StartNew();
            
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
