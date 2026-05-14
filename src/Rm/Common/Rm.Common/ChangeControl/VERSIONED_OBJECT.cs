using Base.BaseTypes.Identification;

using Rm.DataTypes.DateTime;

namespace Rm.Common.ChangeControl;

/// <summary>
/// Version control abstraction, defining semantics for versioning one complex object.
/// </summary>
public class VERSIONED_OBJECT
{
    /// <summary>
    /// Unique identifier of this version container in the form of a UID with no extension. 
    /// This id will be the same in all instances of the same container in a distributed environment, 
    /// meaning that it can be understood as the uid of the virtual version tree.
    /// </summary>
    public required HIER_OBJECT_ID Uid { get; set; }

    /// <summary>
    /// Reference to object to which this version container belongs, e.g. the id of the containing EHR or other relevant owning entity.
    /// </summary>
    public required OBJECT_REF Owner_Id { get; set; }

    /// <summary>
    /// Time of initial creation of this versioned object.
    /// </summary>
    public required DV_DATE_TIME Time_Created { get; set; }
}
