namespace Base.BaseTypes.Interval;

/// <summary>
/// An Interval of Integer, used to represent multiplicity, cardinality and optionality in models.
/// </summary>
public class Multiplicity_interval : Proper_interval
{
    /// <summary>
    /// Marker to use in string form of interval between limits.
    /// </summary>
    public const string Multiplicity_range_marker = "..";
    /// <summary>
    /// Symbol to use to indicate upper limit unbounded.
    /// </summary>
    public const char Multiplicity_unbounded_marker = '*';
}
