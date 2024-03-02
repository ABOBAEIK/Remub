using Remub.RemubLanguage.BasicTypes;

namespace Remub.RemubLanguage.Data
{
    public class Variable
    {
        public Entity Value;
        public DataType VariableType;
        public string Name;

        public Variable(Entity value, DataType variableType, string name)
        {
            Value = value;
            VariableType = variableType;
            Name = name;
        }
    }
}
