using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            EnemyShipFactory enemyShipFactory = new EnemyShipFactory();
            EnemyShip enemyShip = null;

            Console.WriteLine("Choose type of enemy: (U / R / B)");

            String enemyShipType = Console.ReadLine();
            enemyShip = enemyShipFactory.MakeEnemyShip(enemyShipType);

            if (enemyShip != null)
            {
                DoStuffEnemy(enemyShip);
            }
            else
            {
                Console.WriteLine("U have to choose between: U / R / B.");
            }

            Console.ReadKey();
        }

        public static void DoStuffEnemy(EnemyShip anEnemyShip)
        {
            anEnemyShip.DisplayEnemyShip();
            anEnemyShip.FollowHeroShip();
            anEnemyShip.EnemyShipShoots();
        }
    }
}
