using Rm.Common.Archetyped;

namespace Rm.Ehr.Composition;

/// <summary>
/// Documents the context information of a healthcare event involving the subject of
/// care and the health system. The context information recorded here are independent of
/// the attributes recorded in the version audit, which document the system interaction
/// context, i.e. the context of a user interacting with the health record system.
/// Healthcare events include patient contacts, and any other business activity, such
/// as pathology investigations which take place on behalf of the patient.
/// </summary>
public class EVENT_CONTEXT : PATHABLE
{
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
