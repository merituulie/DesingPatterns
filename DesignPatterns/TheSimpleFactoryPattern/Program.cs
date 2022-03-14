using System;
using TheFactoryPattern.Entities;
using TheFactoryPattern.Entities.SimpleFactoryEntities;
using TheFactoryPattern.TheFactoryMethodPattern;

namespace TheFactoryPatternExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Simple factory
            Console.Write("What kind of ship would you like to have (u / r)? ");
            var shipName1 = Console.ReadLine();
            var ship1 = GetEnemyShip(shipName1);
            ship1.Attack();

            // Factory pattern
            Console.Write("What kind of ship would you like to have (ufoship / rocketship)? ");
            var shipName2 = Console.ReadLine();
            var ship2 = CreateEnemyShip(shipName2);

            if (ship2 is not null)
            {
                ship2.Construct();
                Console.WriteLine("Enemy attack, enemy type {0}, did damage: {1}, gun type {2}",
                    ship2.GetType(),
                    ship2.Damage,
                    ship2.Gun.GetType());
            }

        }

        private static SimpleEnemyShip GetEnemyShip(string shipName)
        {
            return new SimpleEnemyShipFactory().CreateEnemy(shipName);
        }

        private static EnemyShip CreateEnemyShip(string shipName)
        {
            if (shipName.Equals(nameof(UfoShip), StringComparison.OrdinalIgnoreCase))
            {
                return new UfoShip(new EnemyUfoShipFactory());
            }

            if (shipName.Equals(nameof(RocketShip), StringComparison.OrdinalIgnoreCase))
            {
                return new RocketShip(new EnemyRocketShipFactory());
            }

            return null;
        }
    }
}