using System;

namespace Storebæltsforbindelsen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //this is a shool assingment 


            //ask the user for input
            Console.WriteLine("Please enter the number of the different type of vehicle:");

            Console.WriteLine();


            //output to the user and makes the variable motorcycle and sets the value to the user input

            Console.Write("number of motorcycles: ");

            int motorcycle = int.Parse(Console.ReadLine());

            int motorcycles = motorcycle * 2;

            Console.WriteLine();


            //output to the user and makes the variable car and sets the value to the user input

            Console.Write("number of cars: ");

            int car = int.Parse(Console.ReadLine());

            int cars = car * 4;

            Console.WriteLine();


            //output to the user and makes the variable truck and sets the value to the user input

            Console.Write("number of trucks: ");

            int truck = int.Parse(Console.ReadLine());

            int trucks = truck * 6;

            Console.WriteLine();


            //output to the user and makes the variable bus and sets the value to the user input

            Console.Write("number of buses: ");

            int bus = int.Parse(Console.ReadLine());

            int buses = bus * 6;

            Console.WriteLine();


            //sets the totals vehicles and tyres

            int totalVehicles = motorcycle + car + truck + bus;

            int totalTyres = motorcycles + cars + trucks + buses;



            //clear the console 

            Console.Clear();

            //output to the user
            Console.WriteLine("There has been a total of:");
            Console.WriteLine(totalVehicles + " Vehicles:");
            Console.WriteLine(totalTyres + " tyres:");
        }
    }
}
