using System;

namespace TheDecoratorPattern.Entities
{
    internal abstract class Weapon
    {
        internal abstract int GetDamage();

        internal abstract int GetAmmo();

        internal abstract int GetRecoil();
    }
}