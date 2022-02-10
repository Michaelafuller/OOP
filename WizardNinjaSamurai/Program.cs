using System;

namespace WizardNinjaSamurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Ninja mike = new Ninja("Mike");
            Samurai steve = new Samurai("Steve");
            Wizard worley = new Wizard("Worley");

            mike.Attack(steve);
            steve.Attack(mike);
            worley.Heal(mike);
            mike.Steal(steve);
        }
    }
}
