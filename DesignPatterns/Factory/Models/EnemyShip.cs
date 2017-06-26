using System;

namespace Factory
{
    public abstract class EnemyShip
    {
        public string Name { get; set; }
        public double amtDamage { get; set; }

        public void FollowHeroShip()
        {
            Console.WriteLine($"{Name} is following the hero.");
        }

        public void DisplayEnemyShip()
        {
            Console.WriteLine($"{Name} is on the screen.");
        }

        public void EnemyShipShoots()
        {
            Console.WriteLine($"{Name} attacks and does {amtDamage} damage.");
        }
    }
}
