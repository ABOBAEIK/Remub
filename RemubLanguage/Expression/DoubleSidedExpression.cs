using Remub.RemubLanguage.BasicTypes;

namespace Remub.RemubLanguage
{
    public class DoubleSidedExpression : Expression
    {
        public Expression Right;
        public Operator Operator;
        public Expression Left;

        public DoubleSidedExpression(Expression right, Operator @operator, Expression left)
        {
            Right = right;
            Operator = @operator;
            Left = left;
        }

        public override Entity Result()
        {
            return Operator.Result(Right, Left);
        }
    }
}
