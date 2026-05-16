namespace Odin.Odin.Tests;

public class OdinParserTests
{
    [Fact]
    public void ImplicitObjectDocument_IsParsed()
    {
        // Arrange
        string ImplicitObjectDocument = @"
        attr_1 = <""Some value"">
        ";

        var tokens = OdinLexer.Tokenize(ImplicitObjectDocument);
        var parser = new OdinParser(tokens);

        // Act
        var odinDocument = parser.ParseDocument();

        // Assert
        var odinMember = Assert.IsType<OdinMember>(odinDocument.Members.Single());
        Assert.Equal("attr_1", odinMember.Key);
        var odinValue = Assert.IsType<OdinValue>(odinMember.Value);
        Assert.Equal("Some value", odinValue.Value);
    }

    [Fact]
    public void AnonymousObjectDocument_IsParsed()
    {
        string AnonymousObjectDocument = @"
    <
        attr_1 = <
            attr_2 = <""Some value"">
        >
    >
    ";

        var tokens = OdinLexer.Tokenize(AnonymousObjectDocument);
        var parser = new OdinParser(tokens);

        // Act
        var odinDocument = parser.ParseDocument();

        // Assert
        var anonymous_root = Assert.Single(odinDocument.Members, p => p.Key == null);
        var anonymous_root_object = Assert.IsType<OdinObject>(anonymous_root.Value);
        var attr_1 = Assert.Single(anonymous_root_object.Members, p => p.Key == "attr_1");
        var attr_1_object = Assert.IsType<OdinObject>(attr_1.Value);

        var attr_2 = Assert.Single(attr_1_object.Members, p => p.Key == "attr_2");
        var attr_2_object = Assert.IsType<OdinValue>(attr_2.Value);
        Assert.Equal("Some value", attr_2_object.Value);

    }

    [Fact]
    public void IdentifiedObjectDocument_IsParsed()
    {
        string IdentifiedObjectDocument = @"
        [""id_1""] = <
            attr_1 = <
                attr_12 = <""leaf_value"">
            >
        >";

        var tokens = OdinLexer.Tokenize(IdentifiedObjectDocument);
        var parser = new OdinParser(tokens);

        // Act
        var odinNode = parser.ParseDocument();

    }
}
