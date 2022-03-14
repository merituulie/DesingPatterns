using TheFactoryPattern.Entities;
using TheFactoryPattern.Entities.EnemyComponents.Guns;
using TheFactoryPattern.Entities.EnemyComponents.Motors;
using TheFactoryPattern.Entities.EnemyComponents.Wings;

namespace TheFactoryPattern.TheFactoryMethodPattern
{
    public class EnemyUfoShipFactory : EnemyShipFactory<UfoShip>
    {
        public override Gun CreateOffence()
        {
            return new LaserBeam();
        }

        public override Motor CreateMotor()
        {
            return new SpeedMotor();
        }

        public override Wings CreateWings()
        {
            return new NoWings();
        }
    }
}
