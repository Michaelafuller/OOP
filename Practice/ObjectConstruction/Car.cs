using System;

namespace ObjectConstruction
{
    class Car : Vehicle
    {
        public string Make;
        public string Model;

        public Car(string color, string make, string model) : base(color)
        {
            Make = make;
            Model = model;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
        }

        public void Drive(double distance)
        {
            Odometer += distance;
            Console.WriteLine("I am driving!");
        }

    }   
}