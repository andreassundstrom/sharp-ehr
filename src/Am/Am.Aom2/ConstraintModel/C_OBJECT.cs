using Base.BaseTypes.Interval;

namespace Am.Aom2.ConstraintModel;

public abstract class C_OBJECT : ARCHETYPE_CONSTRAINT
{
    /// <summary>
    /// Reference model type that this node corresponds to.
    /// </summary>
    public required string rm_type_name { get; set; }

    /// <summary>
    /// Occurrences of this object node in the data, under 
    /// the owning attribute. Upper limit can only be greater 
    /// than 1 if owning attribute has a cardinality of more than 1.
    /// Only set if it overrides the parent archetype in the case of 
    /// specialised archetypes, or else the occurrences inferred from 
    /// the underlying reference model existence and/or cardinality of 
    /// the containing attribute.
    /// </summary>
    public Multiplicity_interval? occurrences { get; set; }

    /// <summary>
    /// Semantic identifier of this node, used to dis-tinguish sibling 
    /// nodes. All nodes must have a node_id; for nodes under a 
    /// container C_ATTRIBUTE, the id must be an id-code must be 
    /// defined in the archetype terminology. For valid structures, 
    /// all node ids are id-codes.
    /// 
    /// For C_PRIMITIVE_OBJECTs represented in ADL inline form, this 
    /// attribute will have the special value Primitive_node_id; 
    /// otherwise it will have the node id read during parsing.
    /// </summary>
    public required string node_id { get; set; }

    /// <summary>
    /// True if this node and by implication all sub-nodes are 
    /// deprecated for use.
    /// </summary>
    public bool? is_deprecated { get; set; }

    /// <summary>
    /// Optional indicator of order of this node with respect to another sibling. Only meaningful in a specialised archetype for a C_OBJECT within a C_ATTRIBUTE with is_multiple = True.
    /// </summary>
    public SIBLING_ORDER? sibling_order { get; set; }
}
