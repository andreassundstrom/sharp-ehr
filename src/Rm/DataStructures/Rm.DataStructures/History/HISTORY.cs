using Base.BaseTypes.TimeTypes;

using Rm.Common.Archetyped;
using Rm.DataStructures.ItemStructure;
using Rm.DataTypes.DateTime;

namespace Rm.DataStructures.History;

public class HISTORY<T> : DATA_STRUCTURE
{
    public required DV_DATE_TIME Origin { get; set; }
    public DV_DURATION? Period { get; set; }
    public DV_DURATION? Duration { get; set; }
    public ITEM_STRUCTURE? Summary { get; set; }

    public override Rm.DataTypes.Text.DV_TEXT Concept()
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
