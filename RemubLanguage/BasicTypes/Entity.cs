using Remub.RemubLanguage.Data;

namespace Remub.RemubLanguage.BasicTypes
{
    public class Entity
    {
        public virtual Text AsText()
        {
            return Text.Empty;
        }

        public virtual Entity Plus(Entity entity)
        {
            return new Entity();
        }

        public virtual Entity Minus(Entity entity)
        {
            return new Entity();
        }
    }
}
