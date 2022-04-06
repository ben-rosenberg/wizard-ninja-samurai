using System;

namespace Characters
{
    class Ninja : Human
    {
        public Ninja(string name)
            : base(name, 3, 3, 175, 100)
        {
        }

        public override int Attack(Human target)
        {
            Console.WriteLine($"{Name} attacking {target.Name}...");
            Random random = new Random();
            int targetHealth = target.Health;
            int attackAmount = (Dexterity * 5 < target.Health) ? Dexterity * 5 : targetHealth;
            double randNum = random.NextDouble();

            if (randNum >= 0.8)
            {
                Console.WriteLine("Addition Damage is Dealt! (20% Chance)");
                attackAmount = (attackAmount + 10 < target.Health) ? attackAmount + 10 : target.Health;
            }

            targetHealth -= attackAmount;
            Console.WriteLine($"Damage Dealt: {attackAmount}");
            Console.WriteLine($"{target.Name}'s New Health: {targetHealth}");
            return attackAmount;
        }

        public void Steal(Human target)
        {
            _Health += 5;
            target.Health -= 5;
            Console.WriteLine($"{Name}'s Ninja stealth allows {Name} to steal 5 HP from {target.Name}!");
            Console.WriteLine($"{Name}'s New Health: {_Health}; {target.Name}'s New Health: {target.Health}");
        }
    }
}