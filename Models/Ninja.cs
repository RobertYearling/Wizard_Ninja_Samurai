using System;

namespace WizNinSam.Models
{
    class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            Dexterity = 175;
        }

        public override int Attack(Human target)
        {
            Random rand = new Random();
            int chance = rand.Next(0, 100);
            int dmg;
            if(chance < 20)
            {
                dmg = 5 * target.Dexterity + 10;
            }
            else{
                dmg = 5 * target.Dexterity;
            }
            target.Dexterity -= dmg;
            Console.WriteLine($"{Name} attached {target.Name} for {dmg} happiness and now {target.Dexterity} ");
            return target.Dexterity;
        }

        public void Steal(Human target)
        {
            int dmg = 5;
            target.damage(dmg);
            setHealth(Health + 5);
        }
    }
}