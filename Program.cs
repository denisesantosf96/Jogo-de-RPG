using System;
using JogoRPG.src.Entities;

namespace JogoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus",23,"Knight",469/749,72/72);
            Wizard wizard = new Wizard("Jenica",23,"White Wizard",325/601,474/482);
            Ninja ninja = new Ninja("Wedge",23,"Ninja",292/574,89/89);
            WizardBlack wizardBlack = new WizardBlack("Topapa",23,"Black Wizard",106/385,611/641);

            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack(2));
            Console.WriteLine(wizard.Attack(8));
            Console.WriteLine(ninja.Attack());
            Console.WriteLine(wizardBlack.Attack(4));
            Console.WriteLine(wizardBlack.Attack(10));
        }
    }
}

