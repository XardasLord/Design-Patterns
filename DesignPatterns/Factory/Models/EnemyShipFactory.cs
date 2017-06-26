using System;

namespace Factory
{
    public class EnemyShipFactory
    {
        public EnemyShip MakeEnemyShip(String newShipType)
        {
            EnemyShip newShip = null;

            switch (newShipType)
            {
                case "U":
                    newShip = new UFOEnemyShip();
                    break;
                case "R":
                    newShip = new RocketEnemyShip();
                    break;
                case "B":
                    newShip = new BigUFOEnemyShip();
                    break;
                default:
                    newShip = null;
                    break;
            }

            return newShip;
        }
    }
}
