namespace Am.Aom2.Definitions;

public class ADL_CODE_DEFINITIONS
{
    /// <summary>
    /// String leader of ‘identifier’ codes, i.e.codes used to identify archetype nodes.
    /// </summary>
    public const string Id_code_leader = "id";

    /// <summary>
    /// String leader of ‘value’ codes, i.e.codes used to identify codes values, including value set members.
    /// </summary>
    public const string Value_code_leader = "at";

    /// <summary>
    /// String leader of ‘value set’ codes, i.e.codes used to identify value sets.
    /// </summary>
    public const string Value_set_code_leader = "ac";

    /// <summary>
    /// Character used to separate numeric parts of codes belonging to different specialisation levels.
    /// </summary>
    public const char Specialisation_separator = '.';


    /// <summary>
    /// Regex used to define the legal numeric part of any archetype code.Corresponds to the simple pattern of dotted numbers, as used in typical multi-level numbering schemes.
    /// </summary>
    public const string Code_regex_pattern = @"(0|[1-9][0-9]*)(\.(0|[1-9][0-9]*))*";

    /// <summary>
    /// Regex pattern of the root id code of any archetype.Corresponds to codes of the form id1, id1.1, id1.1.1 etc..
    /// </summary>
    public const string Root_code_regex_pattern = @"^id1(\.1)*$";

    /// <summary>
    /// Code id used for C_PRIMITIVE_OBJECT nodes on creation.
    /// </summary>
    public const string Primitive_node_id = "id9999";
}
