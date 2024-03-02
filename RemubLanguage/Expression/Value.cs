using Remub.RemubLanguage.BasicTypes;

namespace Remub.RemubLanguage
{
    public class Value : Expression
    {
        public Entity Entity;

        public Value(Entity entity)
        {
            Entity = entity;
        }

        public override Entity Result()
        {
            return Entity;
        }
    }
}
