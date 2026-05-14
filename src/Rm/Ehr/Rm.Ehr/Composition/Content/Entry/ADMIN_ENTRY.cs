using Rm.Common.Archetyped;
using Rm.DataStructures.ItemStructure;
using Rm.DataTypes.Text;

namespace Rm.Ehr.Composition.Content.Entry;

/// <summary>
/// Entry subtype for administrative information, i.e. information about setting up the clinical process, but not itself clinically relevant. Archetypes will define contained information.
///
/// Used for administrative details of admission, episode, ward location, discharge, appointment(if not stored in a practice management or appointments system).
///
/// Not to be used for any clinically significant information.
/// </summary>
public class ADMIN_ENTRY : ENTRY
{
    public required ITEM_STRUCTURE Data { get; set; }

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
