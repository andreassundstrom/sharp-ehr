using Base.BaseTypes.Interval;

namespace Am.Aom2.ConstraintModel;

public class C_ATTRIBUTE : ARCHETYPE_CONSTRAINT
{

    /// <summary>
    /// Reference model attribute within the enclosing type represented 
    /// by a C_OBJECT.
    /// </summary>
    public required string rm_attribute_name { get; set; }


    /// <summary>
    /// Constraint settable on every attribute, regardless of whether it 
    /// is singular or of a container type, which indicates whether its 
    /// target object exists or not(i.e. is mandatory or not). Only set 
    /// if it overrides the underlying reference model or parent archetype 
    /// in the case of specialised archetypes.
    /// </summary>
    public Multiplicity_interval? existence { get; set; }


    /// <summary>
    /// Child C_OBJECT nodes.Each such node represents a constraint on the type of this attribute in its reference model.Multiples occur both for multiple items in the case of container attributes, and alternatives in the case of singular attributes.
    /// </summary>
    public List<C_OBJECT>? children { get; set; }


    /// <summary>
    /// Path to the parent object of this attribute(i.e.doesn’t include the name of this attribute). Used only for attributes in differential form, specialised archetypes.Enables only the re-defined parts of a specialised archetype to be expressed, at the path where they occur.
    /// </summary>
    public string? differential_path { get; set; }


    /// <summary>
    /// Cardinality constraint of attribute, if a container attribute.
    /// </summary>
    public Cardinality? cardinality { get; set; }

    /// <summary>
    /// Flag indicating whether this attribute constraint is on a container(i.e.multiply - valued) attribute.
    /// </summary>
    public required bool is_multiple { get; set; }
}
