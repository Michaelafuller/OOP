using System;

namespace WizardNinjaSamurai
{
    public class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            Dexterity = 175;
        }

        public override int Attack(Human target)
        {
            int dmg = Dexterity * 5;
            target.health -= dmg;

            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            Random rand = new Random();

            if (rand.Next(5) <= 1)
            {
                target.health -= 10;
                Console.WriteLine($"{target.Name} receives an additional 10 damage due to a critical strike!");
            }

            return target.health;
        }

        public int Steal(Human target)
        {
            target.health -= 5;
            this.health += 5;
            Console.WriteLine($"Through some bizarre act of vampirism, {Name} steals 5 health from {target}!");
            return target.health;
        }
    }
}