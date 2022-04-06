using System;
using Characters;

namespace WizardsNinjasSam
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard ben = new Wizard("Ben");
            Human daniel = new Human("Daniel");
            Ninja ninja = new Ninja("Ninja");
            Samurai samurai = new Samurai("Samurai");
            daniel.Attack(ben);
            Console.WriteLine(ben.Health);
            ben.Attack(daniel);
            ninja.Attack(daniel);
            Console.WriteLine(ben.Health);
            ben.Heal(daniel);
            Console.WriteLine(daniel.Health);
            
            ben.Attack(samurai);
            samurai.Meditate();

            ninja.Steal(ben);
        }
    }
}
