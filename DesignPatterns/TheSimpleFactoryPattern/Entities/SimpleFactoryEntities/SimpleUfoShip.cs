using System;

namespace TheFactoryPattern.Entities.SimpleFactoryEntities
{
    public class SimpleUfoShip : SimpleEnemyShip
    {
        public int Damage = 100;

        public override void Attack()
        {
            Console.WriteLine("Attacked! Did damage for: {0}", Damage);
        }
    }
}
