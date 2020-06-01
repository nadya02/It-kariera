using System;
using System.Linq;
using Vehicles_rightWay.Entities;

namespace Vehicles_rightWay
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputCar = Console.ReadLine().Split().ToArray();
            Car car = new Car(double.Parse(inputCar[1]), double.Parse(inputCar[2]));
            string[] inputTruck = Console.ReadLine().Split().ToArray();
            Truck truck = new Truck(double.Parse(inputTruck[1]), double.Parse(inputTruck[2]));
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split().ToArray();
                if(commands[1] == "Car")
                {
                    if (commands[0] == "Drive")
                    {
                        Console.WriteLine(car.Drive(double.Parse(commands[2]), 0));
                    }
                    else
                    {
                        car.Refuel(double.Parse(commands[2]));
                    }
                }
                else
                {
                    if (commands[0] == "Drive")
                    {
                        Console.WriteLine(truck.Drive(double.Parse(commands[2]), 0));
                    }
                    else
                    {
                        truck.Refuel(double.Parse(commands[2]));
                    }
                }               
            }
            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
        }
    }
}
