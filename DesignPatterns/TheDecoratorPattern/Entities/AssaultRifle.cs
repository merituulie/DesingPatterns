using TheDecoratorPattern.Entities;

namespace TheDecoratorPattern.Decorators
{
    internal class AssaultRifle : Weapon
    {
        private int _Damage = 50;
        private int _Ammo = 20;
        private int _Recoil = 75;

        internal override int GetDamage()
        {
            return _Damage;
        }

        internal override int GetAmmo()
        {
            return _Ammo;
        }

        internal override int GetRecoil()
        {
            return _Recoil;
        }
    }
}