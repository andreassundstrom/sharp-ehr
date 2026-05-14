using Base.BaseTypes.Identification;

namespace Rm.DataTypes.Text;

/// <summary>
/// A fully coordinated(i.e.all coordination has been performed) term from a terminology service(as distinct from a particular terminology).
/// </summary>
public class CODE_PHRASE
{
    /// <summary>
    /// Identifier of the distinct terminology from which the code_string(or its elements) was extracted.
    /// </summary>
    public required TERMINOLOGY_ID Terminology_Id { get; set; }

    /// <summary>
    /// The key used by the terminology service to identify a concept or coordination of concepts.This string is most likely parsable inside the terminology service, but nothing can be assumed about its syntax outside that context.
    /// </summary>
    public required string Code_String { get; set; }

    /// <summary>
    /// Optional attribute to carry preferred term corresponding to the code or expression in code_string.Typical use in integration situations which create mappings, and representing data for which both a(non - preferred) actual term and a preferred term are both required.
    /// </summary>
    public string? Preferred_Term { get; set; }
}
