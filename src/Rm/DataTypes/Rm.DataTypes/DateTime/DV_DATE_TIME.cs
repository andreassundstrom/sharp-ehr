namespace Rm.DataTypes.DateTime;

/// <summary>
/// Represents an absolute point in time, specified to the second. Semantics defined by ISO 8601.
///
/// Used for recording a precise point in real world time, and for approximate time stamps, e.g.the origin of a HISTORY in an OBSERVATION which is only partially known.
/// </summary>
public class DV_DATE_TIME
{
    /// <summary>
    /// ISO8601 date/time string.
    /// </summary>
    public required string Value { get; set; }
}
