using System;
using TheFactoryPattern.Entities.EnemyComponents.Guns;

namespace TheFactoryPattern.Entities
{
    public abstract class EnemyShip
    {
        public int Damage;
        public string Name;
        public Gun Gun;

        public abstract void Construct();

        public void Attack()
        {
            Console.WriteLine("Attacked! Did damage for: {0}", Damage);
        }
    }
}