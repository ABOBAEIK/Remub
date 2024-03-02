using Remub.RemubLanguage.BasicTypes;

namespace Remub.RemubLanguage
{
    public class Token
    {
        public TokenType Type;
        public string Text;
        public int Position;

        public Token(TokenType type, string text, int position)
        {
            Type = type;
            Text = text;
            Position = position;
        }
    }
}
