using System;

namespace WizardNinjaSamurai
{
    public class Wizard : Human
    {
        public Wizard(string name) : base(name)
        {
            Intelligence = 25;
            health = 50;

        }

        public override int Attack(Human target)
        {
            int dmg = Intelligence * 5;
            target.health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            this.health += dmg;
            Console.WriteLine($"{Name} was also healed by {dmg}!");
            return target.health;
        }

        public int Heal(Human target)
        {
            int HealAmnt = 10 * Intelligence;
            target.health += HealAmnt;
            Console.WriteLine($"{target} was healed for {HealAmnt}!");
            return target.health;
        }
    }
}