using System;
using System.Collections.Generic;

namespace ObjectConstruction
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Vehicle myVehicle = new Vehicle(7, "Green");
            Console.WriteLine($"My Vehicle is holding {myVehicle.NumPassengers} people.");

            Vehicle green = new Vehicle(5, "Green");
            Vehicle red = new Vehicle("Red");
            Vehicle blue = new Vehicle(8, "Blue");

            Car newCar = new Car("Blue", "Mazda", "Miata");
            Car anotherCar = new Car("Brown", "Ferrari", "Testerosa");

            List<Vehicle> vehicles = new List<Vehicle>();

            Person mike = new Person();
            mike.AddToVehicles(green);
            mike.AddToVehicles(red);
            mike.AddToVehicles(blue);

            mike.AddToVehicles(newCar);
            mike.AddToVehicles(anotherCar);

            mike.DisplayVehicles();
        }
    }
}
