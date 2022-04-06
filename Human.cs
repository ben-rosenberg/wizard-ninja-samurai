using System;

namespace Characters
{
    class Human
    {
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            _Health = 100;
        }

        public Human(
                string name,
                int strength,
                int intelligence,
                int dexterity,
                int health
            )
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            _Health = health;
            _DefaultHealth = health;
        }

        public virtual int Attack(Human target)
        {
            Console.WriteLine($"{this.Name} attacking {target.Name}...");
            int attackAmount = (this.Strength * 5 < target._Health) ? this.Strength * 5 : target._Health;
            target._Health -= attackAmount;
            Console.WriteLine($"Damage Dealt: {attackAmount}");
            Console.WriteLine($"{target.Name}'s New Health: {target._Health}");
            return attackAmount;
        }

        protected virtual int ModifyHealth(int amount)
        {
            _Health += amount;
            return amount;
        }

        public int Health { get => _Health; set => _Health = value; }

        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;

        protected int _Health;
        protected int _DefaultHealth = 100;
    }
}