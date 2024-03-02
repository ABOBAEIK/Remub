using Remub.RemubLanguage.BasicOperation;

namespace Remub.RemubLanguage
{
    public class Parser
    {
        public Token[] Tokens = Array.Empty<Token>();
        public int Position;

        public void Parse()
        {
            int length = Tokens.Length;
            while (Position < length)
            {
                if (KeyWord.IsKeyWord(Tokens[Position], out KeyWord keyWord))
                {
                    keyWord.Call(this);
                }
                else
                {

                }
                Position += 1;
            }
        }
    }
}
