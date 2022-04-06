using System;

namespace Characters
{
    class Samurai : Human
    
    {
        public Samurai(string name)
            : base(name, 3, 3, 3, 200)
        {
        }

        public override int Attack(Human target)
        {
            int attackAmount = base.Attack(target);
            int targetHealth = target.Health;

            if (targetHealth < 50)
            {
                Console.WriteLine($"{Name} has become too weak to combat the samurai's attacks! Health reduced to 0.");
                attackAmount += targetHealth;
                targetHealth = 0;
                return attackAmount;
            }

            return attackAmount;
        }

        public void Meditate()
        {
            Console.WriteLine($"{Name} meditating...");
            _Health = _DefaultHealth;
            Console.WriteLine($"Health restored to {_Health}");
        }
    }
}