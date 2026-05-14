namespace Base.BaseTypes.TimeTypes;

/// <summary>
/// Represents a period of time with respect to a notional point in time, which is not specified.A sign may be used to 
/// indicate the duration is backwards in time rather than forwards.
/// 
/// Note: two deviations from ISO 8601 are supported, the first, to allow a negative sign, and the second allowing 
/// the 'W' designator to be mixed with other designators.See time types section in the Foundation Types model.
/// Used for recording the duration of something in the real world, particularly when there is a need a) to 
/// represent the duration in customary format, i.e.days, hours, minutes etc, and b) if it will be used in 
/// computational operations with date/time quantities, i.e.additions, subtractions etc.
/// 
/// Misuse: Durations cannot be used to represent points in time, or intervals of time.
/// 
/// TODO: DV_DURATION should inherit from both DV_AMOUNT and Iso8601_duration.
/// </summary>
public class DV_DURATION
{
    /// <summary>
    /// ISO8601 duration string, including described deviations to support negative values and weeks.
    /// </summary>
    public required string Value { get; set; }
}
