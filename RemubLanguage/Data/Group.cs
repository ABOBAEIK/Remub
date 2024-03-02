using Remub.RemubLanguage.BasicTypes;

namespace Remub.RemubLanguage.Data
{
    public class Group : Entity
    {
        public string Name;
        public Variable[] InternalData = Array.Empty<Variable>();

        public Group(string name)
        {
            Name = name;
        }
    }
}
