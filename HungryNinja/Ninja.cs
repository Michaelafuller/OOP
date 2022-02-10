using System;
using System.Collections.Generic;
namespace HungryNinja
{
    public class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;
        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();

        }
        public bool IsFull
        {
            get 
            {
                return calorieIntake > 1200;

            }
        }

        public bool Eat(Food item)
        {
            if (!IsFull)
            {
                calorieIntake += item.Calories;
                FoodHistory.Add(item);
                Console.WriteLine($"Ninja ate {item.Name}");
            }
            else
            {
                Console.WriteLine("Ninja is full for now.");
            }

            return IsFull;
        }
    }
}