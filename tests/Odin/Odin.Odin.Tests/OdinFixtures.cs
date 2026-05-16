namespace Odin.Odin.Tests;

internal static class OdinFixtures
{
    internal const string ImplicitObjectDocument = @"
        attr_1 = <""Some value"">
        ";

    internal const string AnonymousObjectDocument = @"
    <
        attr_1 = <
            attr_2 = <""Some value"">
        >
    >
    ";
    internal const string IdentifiedObjectDocument = @"
        [""id_1""] = <
            attr_1 = <
                attr_12 = <""leaf_value"">
            >
        >";
}
