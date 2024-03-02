namespace Remub.RemubLanguage.BasicOperation
{
    public class KeyWord
    {
        public static readonly KeyWord[] Keywords =
        {
            new("tell", (parser) =>
            {
                parser.Position += 1;
                string output = Expression.CreateTree(parser).Result().AsText().ToString();
                Console.WriteLine(output);
            })
        };

        public readonly string Name;

        public KeyWord(string name, Action<Parser> call)
        {
            Name = name;
            Call = call;
        }

        public Action<Parser> Call;

        public static bool IsKeyWord(Token token, out KeyWord keyWord)
        {
            keyWord = null!;
            foreach (var word in Keywords)
            {
                if (word.Name == token.Text)
                {
                    keyWord = word;
                    return true;
                }
            }
            return false;
        }
    }
}
