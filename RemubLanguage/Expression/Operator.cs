using Remub.RemubLanguage.BasicTypes;

namespace Remub.RemubLanguage
{
    public class Operator
    {
        public static readonly Operator[] Operators =
        {
            new("+", (right, left) =>
            {
                return right.Result().Plus(left.Result());
            }),

            new("-", (right, left) =>
            {
                return right.Result().Minus(left.Result());
            })
        };

        public static bool IsOperator(Token token)
        {
            return Operators.Any(op => token.Text == op.Name);
        }

        public string Name;

        public Operator(string name ,Func<Expression, Expression, Entity> result)
        {
            Name = name;
            Result = result;
        }

        public Func<Expression, Expression, Entity> Result;
    }
}
