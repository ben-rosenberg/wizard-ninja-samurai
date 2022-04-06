using System;

namespace Characters
{
    class Wizard : Human
    {
        public Wizard(string name) 
            : base(name, 3, 25, 3, 50)
            {
            }

        public override int Attack(Human target)
        {
            int attackAmount = base.Attack(target);
            _Health += attackAmount;
            Console.WriteLine($"Wizard Attack Healing {Name} by {attackAmount}; New Health: {_Health}");
            return attackAmount;
        }

        public int Heal(Human target)
        {
            int healAmount = Intelligence * 10;
            target.Health += healAmount;
            return healAmount;
        }
    }
}