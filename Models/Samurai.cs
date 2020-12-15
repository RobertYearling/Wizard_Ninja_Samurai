using System;

namespace WizNinSam.Models
{
    class Samurai : Human
    {
        public Samurai(string name) : base(name)
        {
            setHealth(200);
        }

        public override int Attack(Human target)
        {
            if(target.Health < 50)
            {
                target.setHealth(0);
                Console.WriteLine($"{target.Name} has been terminated");
            }
            Console.WriteLine($"{Name} Did not kill{target.Name}" );
            return target.Health;
        }

        public void Meditate()
        {
            setHealth(200);
            Console.WriteLine($"{Name} is going to meditate. {Health} is been restored.");
        }
    }
}