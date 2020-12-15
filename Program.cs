using System;
using WizNinSam.Models;


namespace WizNinSam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wizards are about to whip some Ninja Ass");
            Ninja NinjaOne = new Ninja("Sweep the legs");
            Console.WriteLine("Welcome to the Stage Wizard Miyagi");
            Wizard WizardOne = new Wizard("Wizard Miyagi");
            Console.WriteLine("Special Guest Featuring Samurai Stubbed Toe");
            Samurai SamuraiOne = new Samurai("Stubbed Toe");
            Console.WriteLine("Welcome Domo Arigato");
            Ninja NinjaTwo = new Ninja("Ninja Domo Arigato");
            NinjaOne.Attack(WizardOne);
            WizardOne.Attack(NinjaTwo);
            WizardOne.Attack(NinjaOne);
            SamuraiOne.Stats();
            SamuraiOne.Meditate();
            WizardOne.Stats();
            NinjaOne.Stats();
            NinjaTwo.Stats();
        }
    }
}
