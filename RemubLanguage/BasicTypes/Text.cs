namespace Remub.RemubLanguage.BasicTypes
{
    public class Text : Entity
    {
        public static readonly Text Empty = new Text(string.Empty);

        private string _value;

        public Text(string value)
        {
            _value = value;
        }

        public override Text AsText()
        {
            return this;
        }

        public override string ToString()
        {
            return _value;
        }
    }
}
