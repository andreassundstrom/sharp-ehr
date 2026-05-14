using Rm.Common.Archetyped;
using Rm.DataStructures.ItemStructure;
using Rm.DataTypes.Text;

namespace Rm.Ehr.Composition.Content.Entry;

/// <summary>
/// Entry type for evaluation statements.Used for all kinds of statements which evaluate other information, such as interpretations of observations, diagnoses, differential diagnoses, hypotheses, risk assessments, goals and plans.
/// 
/// Should not be used for actionable statements such as medication orders - these are represented using the INSTRUCTION type.
/// </summary>
public class EVALUATION : CARE_ENTRY
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
