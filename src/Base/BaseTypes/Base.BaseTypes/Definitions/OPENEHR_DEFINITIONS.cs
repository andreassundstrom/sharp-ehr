namespace Base.BaseTypes.Definitions;

/// <summary>
/// 
/// </summary>
public class OPENEHR_DEFINITIONS : BASIC_DEFINITIONS
{
    /// <summary>
    /// Predefined terminology identifier to indicate it is local to the knowledge resource in which it occurs, e.g. an archetype
    /// </summary>
    public string Local_Terminology_Id { get; set; } = "local";
}
