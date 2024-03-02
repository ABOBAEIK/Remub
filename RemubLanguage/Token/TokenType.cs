namespace Remub.RemubLanguage
{
    public class TokenType
    {
        public static readonly TokenType[] TokenTypes =
        {
            new(@"[\s]", TokenDesignation.Space),

            new("[A-Za-z]+", TokenDesignation.Word),
            new("[0-9]+", TokenDesignation.Number),
            new(@"'[^']+'", TokenDesignation.Text),

            new(@"\+", TokenDesignation.Plus),
            new("-", TokenDesignation.Minus),

            new("#", TokenDesignation.ExpressionEnd)
        };

        public static bool IsEnd(TokenType type)
        {
            return type.Designation == TokenDesignation.ExpressionEnd;
        }

        public readonly string Regex;
        public TokenDesignation Designation;

        public TokenType(string regex, TokenDesignation designation)
        {
            Regex = regex;
            Designation = designation;
        }
    }
}
