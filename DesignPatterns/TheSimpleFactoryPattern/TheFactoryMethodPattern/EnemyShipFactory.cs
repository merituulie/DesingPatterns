using TheFactoryPattern.Entities.EnemyComponents.Guns;
using TheFactoryPattern.Entities.EnemyComponents.Motors;
using TheFactoryPattern.Entities.EnemyComponents.Wings;

namespace TheFactoryPattern.TheFactoryMethodPattern
{
    public abstract class EnemyShipFactory<T>
    {
        public abstract Gun CreateOffence();
        public abstract Motor CreateMotor();
        public abstract Wings CreateWings();
    }
}
