using System;
using TheDecoratorPattern.Decorators;
using TheDecoratorPattern.Entities;
using TheDecoratorPattern.Entities.Decorators;

namespace TheDecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var weapon1 = new AssaultRifle();
            PrintWeaponDetails(weapon1);

            var weapon2 = new ExplosiveAmmoDecorator(new FullMagDecorator(new SpeedGripDecorator(new AssaultRifle())));
            PrintWeaponDetails(weapon2);
        }

        private static void PrintWeaponDetails(Weapon weapon)
        {
            Console.WriteLine("Damage: " + weapon.GetDamage());
            Console.WriteLine("Ammo: " + weapon.GetAmmo());
            Console.WriteLine("Recoil: " + weapon.GetRecoil() + "\n");
        }
    }
}