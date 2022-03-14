using TheFactoryPattern.Entities.SimpleFactoryEntities;

namespace TheFactoryPatternExample
{
    public class SimpleEnemyShipFactory
    {
        public SimpleEnemyShip CreateEnemy(string shipName)
        {
            if (shipName.Equals("u"))
            {
                return new SimpleUfoShip();
            }

            if (shipName.Equals("r"))
            {
                return new SimpleRocketShip();
            }

            return null;
        }
    }
}
