using System;
using Dealership.Src.Entities;

namespace Dealership
{
    class Program
    {
        static void Main(string[] args)
        {
            ////instantiating new objects
            Vehicle Car1 = new Vehicle("Honda", "Civic", 2009, "Silver", 35000.00);
            Vehicle Car2 = new Vehicle("BMW", "X1", 2015, "Black", 103000.00);
            Motorcicle Moto1 = new Motorcicle("Kawazaki", "Ninja 400 KRT", 2021, "Red", 31000.00, 400);

            ////Printing all Car1 object properties by the ToString() method that has been overrided into the Vehicle class
            System.Console.WriteLine(Car1);
            System.Console.WriteLine("------------------------------");
            System.Console.WriteLine(Car2);
            System.Console.WriteLine("------------------------------");
            System.Console.WriteLine(Moto1);
        }
    }
}
