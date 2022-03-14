using TheFactoryPattern.TheFactoryMethodPattern;

namespace TheFactoryPattern.Entities
{
    public class UfoShip : EnemyShip
    {
        private EnemyShipFactory<UfoShip> _Factory;

        public UfoShip(EnemyShipFactory<UfoShip> enemyShipFactory)
        {
            _Factory = enemyShipFactory;
        }

        public override void Construct()
        {
            this.Damage = 10;
            this.Name = "UfoShip";
            this.Gun = this._Factory.CreateOffence();
            this._Factory.CreateMotor();
            this._Factory.CreateWings();
        }
    }
}
