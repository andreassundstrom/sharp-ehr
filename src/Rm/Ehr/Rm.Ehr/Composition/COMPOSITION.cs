using Rm.Common.Archetyped;
using Rm.Common.Generic;
using Rm.DataTypes.Text;
using Rm.Ehr.Composition.Content;

namespace Rm.Ehr.Composition;

/// <summary>
/// Content of one version in a VERSIONED_COMPOSITION. A Composition is considered the unit of modification of the record, the 
/// unit of transmission in record Extracts, and the unit of attestation by authorising clinicians. In this latter sense, 
/// it may be considered equivalent to a signed document.

/// Note: It is strongly recommended that the inherited attribute uid be populated in Compositions, using the UID copied from 
/// the object_id() of the uid field of the enclosing VERSION object. For example, the 
/// ORIGINAL_VERSION.uid 87284370-2D4B-4e3d-A3F3-F303D2F4F34B::uk.nhs.ehr1::2 would be copied to the uid field of the Composition.
/// </summary>
public class COMPOSITION : LOCATABLE
{
    public required CODE_PHRASE Language { get; set; }

    public required CODE_PHRASE Territory { get; set; }

    /// <summary>
    /// Temporal category of this Composition, i.e.
    /// 431|persistent| - of potential life - time validity;
    /// 451|episodic| - valid over the life of a care episode;
    /// 433|event| - valid at the time of recording (long-term validity requires subsequent clinical assessment).
    /// or any other code defined in the openEHR terminology group 'category'.
    /// </summary>
    public required DV_CODED_TEXT Category { get; set; }

    /// <summary>
    /// The clinical session context of this Composition, i.e.the contextual attributes of the clinical session.
    /// </summary>
    public EVENT_CONTEXT? Context { get; set; }

    /// <summary>
    /// The person primarily responsible for the content of the Composition (but not necessarily
    /// its committal into the EHR system). This is the identifier which should appear on the screen.
    /// It may or may not be the person who entered the data. When it is the patient, the special self
    /// instance of PARTY_PROXY will be used.
    /// </summary>
    public required PARTY_PROXY Composer { get; set; }

    public required List<CONTENT_ITEM> Content { get; set; } = [];

    public override DV_TEXT Concept()
    {
        throw new NotImplementedException();
    }

    public override bool IsArchetypeRoot()
    {
        throw new NotImplementedException();
    }

    public override object? ItemAtPath(string path)
    {
        throw new NotImplementedException();
    }

    public override IEnumerable<object> ItemsAtPath(string path)
    {
        throw new NotImplementedException();
    }

    public override PATHABLE? Parent()
    {
        throw new NotImplementedException();
    }

    public override bool PathExists(string path)
    {
        throw new NotImplementedException();
    }

    public override string? PathOfItem(PATHABLE locatable)
    {
        throw new NotImplementedException();
    }
}
