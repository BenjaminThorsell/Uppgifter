using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilSortering
{
    class Car : IComparable<Car>
    {
        string Brand;
        string Model;
        int Year;

        public Car()
        {
            Brand = "unknown";
            Model = "unknown";
            Year = -1;
        }

        public Car(string Brand, string Model, int Year)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.Year = Year; 
        }

        public int year
        {
            get { return Year; }
            set { Year = value; }
        }

        public string brand
        {
            get { return Brand; }
            set { Brand = value; }
        }

        public string model
        {
            get { return Model; }
            set { Model = value; }
        }

        public int CompareTo(Car other)
        {
            return Year.CompareTo(other.Year)*-1;
                                             
        }


        // Operatorer för <, >, != och == \\

        public static bool operator <(Car P1, Car P2)
        {
            return (P1.year < P2.year);
        }

        public static bool operator >(Car P1, Car P2)
        {
            return (P1.year > P2.year);
        }

        public static bool operator ==(Car P1, Car P2)
        {
            return (P1.year == P2.year);
        }

        public static bool operator !=(Car P1, Car P2)
        {
            return (P1.year != P2.year);
        }
    }
}
