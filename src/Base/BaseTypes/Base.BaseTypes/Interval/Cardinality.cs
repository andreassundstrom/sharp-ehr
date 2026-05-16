namespace Base.BaseTypes.Interval;

/// <summary>
/// Express constraints on the cardinality of container objects 
/// which are the values of multiply-valued attributes, including 
/// uniqueness and ordering, providing the means to state that a 
/// container acts like a logical list, set or bag.
/// </summary>
public class Cardinality
{
    /// <summary>
    /// The interval of this cardinality.
    /// </summary>
    public required Multiplicity_interval interval { get; set; }

    /// <summary>
    /// True if the members of the container attribute to which this cardinality refers are ordered.
    /// </summary>
    public required bool is_ordered { get; set; }

    /// <summary>
    /// True if the members of the container attribute to which this cardinality refers are unique.
    /// </summary>
    public required bool is_unique { get; set; }
}
