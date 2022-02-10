using System;

namespace WizardNinjaSamurai
{
    public class Samurai : Human
    {
        public Samurai(string name) : base(name)
        {
            health = 200;
        }

        public override int Attack(Human target)
        {
            if (target.health < 50)
            {
                target.health = 0;
                Console.WriteLine($"{Name} performs and execute, killing {target.Name} instantly! How overpowered!");
            }
            return base.Attack(target);
        }

        public int Meditate()
        {
            if (this.health < 200)
            {
                this.health = 200;
            }
            Console.WriteLine($"{Name} is meditating, recovering all lost health!");
            return this.health;
        }
    }
}