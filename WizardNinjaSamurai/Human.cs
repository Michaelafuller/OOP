using System;

namespace WizardNinjaSamurai
{
    public class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        public int health;

        public int Health
        {
            get { return Health; }
        }

        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }

        // public Human(string name, int strength, int intelligence, int dexterity, int health)
        // {
        //     Name = name;
        //     Strength = strength;
        //     Intelligence = intelligence;
        //     Dexterity = dexterity;
        //     health = health;
        // }

        public virtual int Attack(Human target)
        {
            int dmg = Strength * 3;
            target.health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.health;
        }
    }
}