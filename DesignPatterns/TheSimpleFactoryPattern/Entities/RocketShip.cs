using TheFactoryPattern.TheFactoryMethodPattern;

namespace TheFactoryPattern.Entities
{
    public class RocketShip : EnemyShip
    {
        private EnemyShipFactory<RocketShip> _Factory;

        public RocketShip(EnemyShipFactory<RocketShip> enemyShipFactory)
        {
            _Factory = enemyShipFactory;
        }

        public override void Construct()
        {
            this.Damage = 30;
            this.Name = "RocketShip";
            this.Gun = this._Factory.CreateOffence();
            this._Factory.CreateMotor();
            this._Factory.CreateWings();
        }
    }
}
