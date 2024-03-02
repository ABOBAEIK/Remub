namespace Remub.RemubLanguage.BasicTypes
{
    public class Number : Entity
    {
        private int _value;

        public Number(int value)
        {
            _value = value;
        }

        public override Text AsText()
        {
            return new Text(_value.ToString());
        }

        public override Entity Plus(Entity entity)
        {
            if (entity.GetType() != GetType())
            {
                throw new Exception("you can't add a number to " + entity.GetType());
            }
            Number number = (Number)entity;
            return new Number(_value + number._value);
        }

        public override Entity Minus(Entity entity)
        {
            if (entity.GetType() != GetType())
            {
                throw new Exception("you can't subtract a number from " + entity.GetType());
            }
            Number number = (Number)entity;
            return new Number(_value - number._value);
        }
    }
}
