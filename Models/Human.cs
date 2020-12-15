using System;

namespace WizNinSam.Models
{
    public class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;

        public int Health
        {
            get
            {
                return health;
            }
        }
        public void setHealth(int hp)
        {
            health = hp;
        }
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }
        public Human(string name, int str, int intel, int dex, int hp)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = hp;
        }
        // Build Attack method
        public virtual int Attack(Human target)
        {
            int dmg = Strength * 3;
            target.damage(dmg);
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.health;
        }
        public void damage(int dmg)
        {
            health -= dmg;
        }
        public void healing(int dmg)
        {
            health += dmg;
        }
        public void Stats()
        {
            Console.WriteLine($"{Name} Stats");
            Console.WriteLine($"{Strength} Current Strength");
            Console.WriteLine($"{Intelligence} some intel");
            Console.WriteLine($"{Dexterity} Current Dexterity");
            Console.WriteLine($"{Health} Current Health");
        }
    }
}