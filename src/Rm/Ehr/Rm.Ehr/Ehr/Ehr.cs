using Base.BaseTypes.Identification;

using Rm.DataTypes.DateTime;


namespace Rm.Ehr.Ehr;

/// <summary>
/// The EHR object is the root object and access point of an EHR for a subject of care.
/// </summary>
public class Ehr
{
    /// <summary>
    /// The identifier of the logical EHR management system in which this EHR was created.
    /// </summary>
    public required HIER_OBJECT_ID System_Id { get; set; }

    /// <summary>
    /// The unique identifier of this EHR.
    /// 
    /// Note: is is strongly recommended that a UUID always be used for this field.
    /// </summary>
    public required HIER_OBJECT_ID Ehr_Id { get; set; }

    /// <summary>
    /// List of contributions causing changes to this EHR.Each contribution contains a list of versions, 
    /// which may include references to any number of VERSION instances, i.e.items of type 
    /// VERSIONED_COMPOSITION and VERSIONED_FOLDER.
    /// </summary>
    public List<OBJECT_REF> Contributions { get; set; } = [];

    /// <summary>
    /// Reference to EHR_STATUS object for this EHR.
    /// </summary>
    public required OBJECT_REF Ehr_Status { get; set; }

    /// <summary>
    /// Reference to EHR_ACCESS object for this EHR.
    /// </summary>
    public required OBJECT_REF Ehr_Access { get; set; }

    /// <summary>
    /// Master list of all Versioned Composition references in this EHR.
    /// </summary>
    public List<OBJECT_REF> Compositions { get; set; } = [];

    /// <summary>
    /// Optional directory structure for this EHR. If present, this is a reference to the first member of folders.
    /// </summary>
    public OBJECT_REF? Directory { get; set; }

    /// <summary>
    /// Time of creation of the EHR.
    /// </summary>
    public required DV_DATE_TIME Time_Created { get; set; }

    /// <summary>
    /// Optional additional Folder structures for this EHR.If set, the directory attribute refers to the first member.
    /// </summary>
    public List<OBJECT_REF> Folders { get; set; } = [];
}
