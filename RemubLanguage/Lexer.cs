using System.Text.RegularExpressions;

namespace Remub.RemubLanguage
{
    public class Lexer
    {
        private List<Token> _tokens = new List<Token>();
        public string Code = string.Empty;

        private int _position = 0;

        public Token[] LexicalAnalysis()
        {
            int length = Code.Length;
            while (_position < length)
            {
                _tokens.Add(GetToken());
            }
            return _tokens.Where(token => token.Type.Designation != TokenDesignation.Space).ToArray();
        }

        private Token GetToken()
        {
            string substringed = Code.Substring(_position);
            foreach (TokenType tokenType in TokenType.TokenTypes)
            {
                Match match = Regex.Match(substringed, "^" + tokenType.Regex);
                if (match.Success)
                {
                    _position += match.Value.Length;
                    return new Token(tokenType, match.Value, _position);
                }
            }
            throw new Exception("There is an unidentified object in " + _position + " position");
        }
    }
}
