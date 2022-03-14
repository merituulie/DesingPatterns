using System;

namespace TheFactoryPattern.Entities.SimpleFactoryEntities
{
    public class SimpleRocketShip : SimpleEnemyShip
    {
        public int Damage = 250;

        public override void Attack()
        {
            Console.WriteLine("Attacked! Did damage for: {0}", Damage);
        }
    }
}
