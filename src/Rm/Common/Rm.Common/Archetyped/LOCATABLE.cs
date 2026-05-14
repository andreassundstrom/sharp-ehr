using Rm.DataTypes.Text;

namespace Rm.Common.Archetyped;

/// <summary>
/// Root class of all information model classes that can be archetyped. 
/// Most classes in the openEHR reference model inherit from the LOCATABLE class,
/// which defines the idea of locatability in an archetyped structure. LOCATABLE
/// defines a runtime name and an archetype_node_id.
/// </summary>
public abstract class LOCATABLE : PATHABLE
{
    /// <summary>
    /// Runtime name of this fragment, used to build runtime paths.This is the term 
    /// provided via a clinical application or batch process to name this EHR 
    /// construct: its retention in the EHR faithfully preserves the original 
    /// label by which this entry was known to end users.
    /// </summary>
    public required DV_TEXT Name { get; set; }

    /// <summary>
    /// Design-time archetype identifier of this node taken from its generating archetype; 
    /// used to build archetype paths. Always in the form of an at-code, e.g. at0005. 
    /// This value enables a 'standardised' name for this node to be generated, by referring 
    /// to the generating archetype local terminology. 
    /// 
    /// At an archetype root point, the 
    /// value of this attribute is always the stringified form of the archetype_id found 
    /// in the archetype_details object.
    /// </summary>
    public required string ArchetypeNodeId { get; set; }

    /// <summary>
    /// Clinical concept of the archetype as a whole (= derived from the archetype_node_id' of the root node)
    /// </summary>
    /// <returns></returns>
    public abstract DV_TEXT Concept();

    /// <summary>
    /// True if this node is the root of an archetyped structure.
    /// </summary>
    /// <returns></returns>
    public abstract bool IsArchetypeRoot();
}