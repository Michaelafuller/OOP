using System;

namespace ObjectConstruction
{
    public class Vehicle
    {
        public int NumPassengers;
        public string Color;
        protected double Odometer;

        public Vehicle(int NumPass, string col)
        {
            NumPassengers = NumPass;
            Color = col;
            Odometer = 0;
        }

        public Vehicle(string col)
        {
            NumPassengers = 5;
            Color = col;
            Odometer = 0;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Number of Passengers: {NumPassengers}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Miles: {Odometer}");
        }

    }
}