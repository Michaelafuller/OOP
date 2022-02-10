using System;
using System.Collections.Generic;
namespace HungryNinja
{
    public class Buffet
    {
        public static List<Food> Menu;

        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Vegetarian Fried Rice", 500, false, false),
                new Food("Vegetarian Cheeseburger", 1000, false, false),
                new Food("Vegetarian Chili", 1000, true, false),
                new Food("Vegetarian 'Chicken' Salad", 700, false, false),
                new Food("Vegetarian Meatloaf", 1500, false, true),
                new Food("Navratam Korma ", 1000, true, true),
                new Food("Vegetarian Tiki Masala", 1000, true, false)
            };
        }

        public Food Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(Menu.Count)];
        }
    }
}