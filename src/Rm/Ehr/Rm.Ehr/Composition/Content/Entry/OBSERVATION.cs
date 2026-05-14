using Rm.Common.Archetyped;
using Rm.DataStructures.History;
using Rm.DataStructures.ItemStructure;
using Rm.DataTypes.Text;

namespace Rm.Ehr.Composition.Content.Entry;

/// <summary>
/// Entry subtype for all clinical data in the past or present, i.e.which(by the time it is recorded) has already 
/// occurred.OBSERVATION data is expressed using the class HISTORY<T>, which guarantees that it is situated in 
/// time.OBSERVATION is used for all notionally objective(i.e.measured in some way) observations of phenomena, 
/// and patient-reported phenomena, e.g.pain.
/// 
/// Not to be used for recording opinion or future statements of any kind, including instructions, intentions, plans etc.
/// </summary>
public class OBSERVATION : CARE_ENTRY
{
    public required HISTORY<ITEM_STRUCTURE> Data { get; set; }

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
