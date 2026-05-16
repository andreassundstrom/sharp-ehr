namespace Odin.Odin.Tests;

public class OdinDocumentTests
{
    /// <summary>
    /// Document without proper identifier, similar to anonymous object document
    /// </summary>
    [Fact]
    public void ImplicitObjectDocument_IsParsed()
    {
        const string ImplicitObjectDocument = @"
        attr_1 = <""Some value"">
        ";

        var expectedTokens = new List<OdinToken>
        {
            new OdinToken(TokenType.Identifier, "attr_1"),
            new OdinToken(TokenType.Equal, "="),
            new OdinToken(TokenType.LessThan, "<"),
            new OdinToken(TokenType.String, "Some value"),
            new OdinToken(TokenType.GreaterThan, ">")
        };

        var actualTokens = OdinLexer.Tokenize(ImplicitObjectDocument);

        Assert.Equivalent(expectedTokens, actualTokens);
    }

    [Fact]
    public void AnonymousObjectDocument_IsParsed()
    {
        const string AnonymousObjectDocument = @"
    <
        attr_1 = <
            attr_2 = <""Some value"">
        >
    >
    ";

        var expectedTokens = new List<OdinToken>
        {
            new OdinToken(TokenType.LessThan,"<"),
            new OdinToken(TokenType.Identifier,"attr_1"),
            new OdinToken(TokenType.Equal,"="),
            new OdinToken(TokenType.LessThan,"<"),
            new OdinToken(TokenType.Identifier,"attr_2"),
            new OdinToken(TokenType.Equal,"="),
            new OdinToken(TokenType.LessThan,"<"),
            new OdinToken(TokenType.String,"Some value"),
            new OdinToken(TokenType.GreaterThan,">"),
        };

        var actualTokens = OdinLexer.Tokenize(AnonymousObjectDocument);

        Assert.Equivalent(expectedTokens, actualTokens);
    }

    [Fact]
    public void IdentifiedObjectDocument_IsParsed()
    {
        const string IdentifiedObjectDocument = @"
        [""id_1""] = <
            attr_1 = <
                attr_12 = <""leaf_value"">
            >
        >";

        var expectedTokens = new List<OdinToken>
        {
            new OdinToken(TokenType.OpenBracket,"["),
            new OdinToken(TokenType.String,"id_1"),
            new OdinToken(TokenType.CloseBracket,"]"),
            new OdinToken(TokenType.Equal,"="),
            new OdinToken(TokenType.LessThan,"<"),
            new OdinToken(TokenType.Identifier,"attr_1"),
            new OdinToken(TokenType.Equal,"="),
            new OdinToken(TokenType.LessThan,"<"),
            new OdinToken(TokenType.Identifier,"attr_12"),
            new OdinToken(TokenType.Equal,"="),
            new OdinToken(TokenType.LessThan,"<"),
            new OdinToken(TokenType.String,"leaf_value"),
            new OdinToken(TokenType.GreaterThan,">"),
            new OdinToken(TokenType.GreaterThan,">"),
            new OdinToken(TokenType.GreaterThan,">"),
        };

        var actualTokens = OdinLexer.Tokenize(IdentifiedObjectDocument);

        Assert.Equivalent(expectedTokens, actualTokens);
    }

}
