namespace Am.Aom2.ConstraintModel;

public class SIBLING_ORDER
{
    /// <summary>
    /// True if the order relationship is ‘before’, if False, it is ‘after’.
    /// </summary>
    public required bool is_before { get; set; }

    /// <summary>
    /// Node identifier of sibling before or after which this node should come.
    /// </summary>
    public required string sibling_node_id { get; set; }
}
