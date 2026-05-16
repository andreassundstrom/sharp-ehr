using Am.Aom2.RmOverlay;

namespace Am.Aom2.Archetype;

/// <summary>
/// The ARCHETYPE class defines the core formal model of the root object of 
/// any archetype or template. It includes only basic identification information, 
/// and otherwise provides the structural connections from the Archetype to 
/// its constituent parts, i.e. definition (a C_COMPLEX_OBJECT), terminology 
/// (ARCHEYTPE_TERMINOLOGY) and so on. It is the parent class of all concrete 
/// types of archetype.
/// </summary>
public abstract class ARCHETYPE
{
    /// <summary>
    /// Archetype reference of the specialisation parent of this archetype, if applicable. May take the form of an archetype interface identifier, i.e. the identifier up to the major version only, or may be a full archetype identifier.
    /// </summary>
    public string? parent_archetype_id { get; set; }

    /// <summary>
    /// Identifier of this archetype.
    /// </summary>
    public required ARCHETYPE_HRID archetype_id { get; set; }

    /// <summary>
    /// Flag indicating whether this archetype is differential or flat in its contents. Top-level source archetypes have this flag set to True.
    /// </summary>
    public required bool is_differential { get; set; }
}
