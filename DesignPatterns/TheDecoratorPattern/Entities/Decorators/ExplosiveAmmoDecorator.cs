namespace TheDecoratorPattern.Entities.Decorators
{
    internal class ExplosiveAmmoDecorator : WeaponUpgrade
    {
        private Weapon _Decorated;
        private int _AddedDamage = 50;
        private int _AddedAmmo = 0;
        private int _ReducedRecoil = 15;

        public ExplosiveAmmoDecorator(Weapon decorated)
        {
            this._Decorated = decorated;
        }

        internal override int GetDamage()
        {
            return this._Decorated.GetDamage() + _AddedDamage;
        }

        internal override int GetAmmo()
        {
            return this._Decorated.GetAmmo() + _AddedAmmo;
        }

        internal override int GetRecoil()
        {
            var recoil = this._Decorated.GetRecoil() - this._ReducedRecoil;
            return recoil < 0 ? 0 : recoil;
        }
    }
}