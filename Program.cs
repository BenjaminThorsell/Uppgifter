using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26Mars_Uppgift_1
{
    class Program
    {
        static void BubbleSort(List<int> sort_list)
        {
            bool list_sorted = false;
            int a = 0;
            while (list_sorted == false)
            {

                list_sorted = true;
                for (int i = 0; i < sort_list.Count - 1 - a; i++)
                {
                    if (sort_list[i] > sort_list[i + 1])
                    {
                        int temp = sort_list[i];
                        sort_list[i] = sort_list[i + 1];
                        sort_list[i + 1] = temp;
                        list_sorted = false;
                    }
                }
                a++;
            }
        }


        static void Main(string[] args)
        {
            Random rand = new Random(2); //bestämmer en "seed" för att se till så att listan slumpas likadant varje gång programmet startas. 

            List<int> list = new List<int>();

            for (int i = 0; i < 1000; i++) // 1000 heltal matas in i listan "list".
            {
                list.Add(rand.Next(0, 100000));
            }

            var watch = System.Diagnostics.Stopwatch.StartNew(); //Tidtagningen påbörjas.
            BubbleSort(list); //Sorteringen med BubbleSort genomförs.
            watch.Stop(); //Tidtagningen avslutas då BubbleSort har utförts. 
            var elapsedms = watch.ElapsedMilliseconds;
            Console.WriteLine("Det tog " + elapsedms + " millisekunder att sortera listan innehållande " + list.Count + " heltal med hjälp av bubblesort.");
            Console.ReadLine();
        }
    }
}
