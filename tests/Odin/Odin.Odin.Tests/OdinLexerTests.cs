namespace Odin.Odin.Tests;

public class OdinLexerTests
{
    /// <summary>
    /// Document without proper identifier, similar to anonymous object document
    /// </summary>
    [Fact]
    public void ImplicitObjectDocument_IsParsed()
    {
        var expectedTokens = new List<OdinToken>
        {
            new OdinToken(TokenType.Identifier, "attr_1"),
            new OdinToken(TokenType.Equal, "="),
            new OdinToken(TokenType.OpenBlock, "<"),
            new OdinToken(TokenType.String, "Some value"),
            new OdinToken(TokenType.CloseBlock, ">")
        };

        var actualTokens = OdinLexer.Tokenize(OdinFixtures.ImplicitObjectDocument);
        Assert.Equivalent(expectedTokens, actualTokens);
    }

    [Fact]
    public void AnonymousObjectDocument_IsParsed()
    {


        var expectedTokens = new List<OdinToken>
        {
            new OdinToken(TokenType.OpenBlock,"<"),
            new OdinToken(TokenType.Identifier,"attr_1"),
            new OdinToken(TokenType.Equal,"="),
            new OdinToken(TokenType.OpenBlock,"<"),
            new OdinToken(TokenType.Identifier,"attr_2"),
            new OdinToken(TokenType.Equal,"="),
            new OdinToken(TokenType.OpenBlock,"<"),
            new OdinToken(TokenType.String,"Some value"),
            new OdinToken(TokenType.CloseBlock,">"),
        };

        var actualTokens = OdinLexer.Tokenize(OdinFixtures.AnonymousObjectDocument);

        Assert.Equivalent(expectedTokens, actualTokens);
    }

    [Fact]
    public void IdentifiedObjectDocument_IsParsed()
    {
        var expectedTokens = new List<OdinToken>
        {
            new OdinToken(TokenType.OpenContainer,"["),
            new OdinToken(TokenType.String,"id_1"),
            new OdinToken(TokenType.CloseContainer,"]"),
            new OdinToken(TokenType.Equal,"="),
            new OdinToken(TokenType.OpenBlock,"<"),
            new OdinToken(TokenType.Identifier,"attr_1"),
            new OdinToken(TokenType.Equal,"="),
            new OdinToken(TokenType.OpenBlock,"<"),
            new OdinToken(TokenType.Identifier,"attr_12"),
            new OdinToken(TokenType.Equal,"="),
            new OdinToken(TokenType.OpenBlock,"<"),
            new OdinToken(TokenType.String,"leaf_value"),
            new OdinToken(TokenType.CloseBlock,">"),
            new OdinToken(TokenType.CloseBlock,">"),
            new OdinToken(TokenType.CloseBlock,">"),
        };

        var actualTokens = OdinLexer.Tokenize(OdinFixtures.IdentifiedObjectDocument);

        Assert.Equivalent(expectedTokens, actualTokens);
    }

}
