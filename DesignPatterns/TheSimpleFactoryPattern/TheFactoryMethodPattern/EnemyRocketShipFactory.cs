using TheFactoryPattern.Entities;
using TheFactoryPattern.Entities.EnemyComponents.Guns;
using TheFactoryPattern.Entities.EnemyComponents.Motors;
using TheFactoryPattern.Entities.EnemyComponents.Wings;

namespace TheFactoryPattern.TheFactoryMethodPattern
{
    public class EnemyRocketShipFactory : EnemyShipFactory<RocketShip>
    {
        public override Gun CreateOffence()
        {
            return new Rocket();
        }

        public override Motor CreateMotor()
        {
            return new BasicMotor();
        }

        public override Wings CreateWings()
        {
            return new DoubleWings();
        }
    }
}
