using System;

namespace WizNinSam.Models
{
    class Wizard : Human
    {
        public Wizard(string name) : base(name)
        {
            setHealth(50);
            Intelligence = 25;
        }

        public override int Attack(Human target)
        {
            Console.WriteLine($"{Name} has {Health} in health and {target.Name} has taken {target.Health} health.");
            int dmg = Intelligence * 5;
            target.damage(dmg);
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage");
            healing(dmg);
            Console.WriteLine($"{Name} has {Health} health and {target.Name} has {target.Health} health {target.Intelligence} in Intelligence ");
            return target.Health;
        }

        public void Heal(Human target)
        {
            int heals = target.Intelligence * 10;
            target.healing(heals);
            Console.WriteLine($"{Name} has healed {target.Name}, and health is {target.Health} ");
        }
    }
}
