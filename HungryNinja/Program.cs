using System;
using System.Collections.Generic;

namespace HungryNinja
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Buffet NinjaBuffet = new Buffet();
            Ninja HungryNinja = new Ninja();

            while (!HungryNinja.IsFull)
            {
                HungryNinja.Eat(NinjaBuffet.Serve());
            }
        }
    }
}
