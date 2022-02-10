using System;
using System.Collections.Generic;

namespace ObjectConstruction
{
    public class Person
    {
        public List<Vehicle> OwnedVehicles;

        public Person()
        {
            OwnedVehicles = new List<Vehicle>();
        }

        public void AddToVehicles(Vehicle newV)
        {
            OwnedVehicles.Add(newV);
        }

        public void DisplayVehicles()
        {
            foreach (var x in OwnedVehicles)
            {
                x.GetInfo();
            }
        }
    }
}