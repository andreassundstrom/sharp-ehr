namespace Odin.Odin;

public class OdinParser
{
    private readonly List<OdinToken> _tokens;
    private int _index = 0;

    public OdinParser(List<OdinToken> tokens)
    {
        _tokens = tokens;
    }

    public OdinObject ParseDocument()
    {
        var rootDocument = new OdinObject();
        var nextType = Peek().Type;

        if (nextType == TokenType.Identifier)
        {
            string key = Consume(TokenType.Identifier).Value;
            Consume(TokenType.Equal);
            var value = ParseValue();
            rootDocument.Members.Add(new OdinMember(key, value));
        }
        else if (nextType == TokenType.OpenBlock)
        {
            var value = ParseValue();
            rootDocument.Members.Add(new OdinMember(value));
        }

        return rootDocument;
    }

    private OdinNode ParseValue()
    {
        // TODO: Handle parsing of types
        // string? explicitType = null;
        var type = Peek()?.Type;

        switch (type)
        {
            case TokenType.OpenBlock:
                return ParseBlock();
            case TokenType.String:
                return new OdinValue(Consume(TokenType.String).Value);
            case TokenType.Number:
                return new OdinValue(double.Parse(Consume(TokenType.Number).Value));
            case TokenType.Boolean:
                return new OdinValue(bool.Parse(Consume(TokenType.Boolean).Value));
            case TokenType.Null:
                Consume(TokenType.Null);
                return new OdinValue(Consume(TokenType.Null));
            default:
                throw new ArgumentOutOfRangeException("Failed to parse the token into valid OdinNode");
        }
    }

    private OdinToken Peek()
    {
        return _index < _tokens.Count ? _tokens[_index] : new OdinToken(TokenType.Null, "");
    }

    private OdinToken Consume(TokenType? tokenType)
    {
        var token = Peek();
        if (token.Type != tokenType)
        {
            throw new ArgumentOutOfRangeException($"Expected token of type {tokenType} but found type {token?.Type}");
        }
        _index++;
        return token;
    }

    private OdinNode ParseBlock()
    {
        var token = Consume(TokenType.OpenBlock);

        if (Peek().Type == TokenType.String)
        {
            return new OdinValue(Consume(TokenType.String).Value);
        }

        var odinObject = new OdinObject();

        while (Peek().Type != TokenType.CloseBlock)
        {
            string key = "";

            // Key is container key ["organisation"] = ... or [1] = ...
            if (Peek().Type == TokenType.OpenContainer)
            {
                Consume(TokenType.OpenContainer);
                var keyToken = Consume(Peek().Type);
                key = keyToken.Value;
                Consume(TokenType.CloseContainer);
            }
            // Key is attribute, organisation = ...
            else if (Peek().Type == TokenType.Identifier)
            {
                key = Consume(TokenType.Identifier).Value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Expected object to start with a container or attribute");
            }

            Consume(TokenType.Equal);

            OdinNode valueNode = ParseValue();

            odinObject.Members.Add(new OdinMember(key, valueNode));
        }

        Consume(TokenType.CloseBlock);
        return odinObject;
    }
}
