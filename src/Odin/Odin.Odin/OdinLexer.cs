namespace Odin.Odin;

public enum TokenType
{
    /// <summary>
    /// The symbol <, open an object block
    /// </summary>
    LessThan,
    /// <summary>
    /// The symbol >, close an object block
    /// </summary>
    GreaterThan,
    /// <summary>
    /// The symbol =, indicate attribute value = object block
    /// </summary>
    Equal,
    /// <summary>
    /// The symbol (, type name or plug-in syntax type delimiters
    /// </summary>
    LeftParenthesis,
    /// <summary>
    /// The symbol ), type name or plug-in syntax type delimiters
    /// </summary>
    RightParenthesis,
    /// <summary>
    /// The symbols <#, open an object block expressed in a plug-in syntax
    /// </summary>
    LessThanOctothorpe,
    /// <summary>
    /// The symbols #>, close an object block expressed in a plug-in syntax
    /// </summary>
    GreaterThanOctothorpe,
    /// <summary>
    /// The symbol ", used to delimit string values
    /// </summary>
    DoubleQuote,
    /// <summary>
    /// The symbol ', used to delimit single character values;
    /// </summary>
    SingleQuote,
    /// <summary>
    /// The symbol |, used to delimit intervals
    /// </summary>
    BarCharacter,
    /// <summary>
    /// The symbol [, used to delimit start of coded term
    /// </summary>
    OpenBracket,
    /// <summary>
    /// The symbol ], used to delimit end of code term
    /// </summary>
    CloseBracket,
    /// <summary>
    /// A string value
    /// </summary>
    String,
    /// <summary>
    /// Identifier for a block
    /// </summary>
    Identifier,
    /// <summary>
    /// Primitive bool value
    /// </summary>
    Boolean,
    /// <summary>
    /// Primitive null value
    /// </summary>
    Null
}

public record OdinToken(TokenType Type, string Value);

public class OdinLexer
{
    public static List<OdinToken> Tokenize(string source)
    {
        var tokens = new List<OdinToken>();
        int i = 0;

        while (i < source.Length)
        {
            char ch = source[i];

            if (char.IsWhiteSpace(ch) || char.Equals(ch, Environment.NewLine))
            {
                i++;
                continue;
            }

            // TODO: Handle comments


            // Structural symbols
            switch (ch)
            {
                case '<':
                    tokens.Add(new OdinToken(TokenType.LessThan, "<"));
                    i++;
                    continue;
                case '>':
                    tokens.Add(new OdinToken(TokenType.GreaterThan, ">"));
                    i++;
                    continue;
                case '=':
                    tokens.Add(new OdinToken(TokenType.Equal, "="));
                    i++;
                    continue;
                case '[':
                    tokens.Add(new OdinToken(TokenType.OpenBracket, "["));
                    i++;
                    continue;
                case ']':
                    tokens.Add(new OdinToken(TokenType.CloseBracket, "]"));
                    i++;
                    continue;
                case '"':
                    int startOfString = ++i;
                    while (i < source.Length && source[i] != '"')
                    {
                        i++;
                    }
                    // Add string without double quotes
                    tokens.Add(new OdinToken(TokenType.String, source[startOfString..i]));
                    i++;
                    continue;
                default:
                    // Not a structural symbol
                    break;
            }

            // Identifiers and primitives
            if (char.IsLetter(ch) || ch == '_')
            {
                int startOfIdentifier = i;

                while (i < source.Length && (char.IsLetterOrDigit(source[i]) || source[i] == '_'))
                {
                    i++;
                }

                string lexeme = source[startOfIdentifier..i];

                var type = lexeme switch
                {
                    // This should be case-insensitive
                    //"true" => TokenType.Boolean,
                    //"false" => TokenType.Boolean,
                    //"null" => TokenType.Null,
                    _ => TokenType.Identifier,
                };

                tokens.Add(new OdinToken(type, lexeme));
                continue;
            }

            throw new ArgumentOutOfRangeException($"Failed to parse the token [{source[i]}] at position {i}");
        }
        return tokens;
    }
}
