using Rm.Common.Archetyped;
using Rm.DataTypes.Text;

namespace Rm.Ehr.Composition;

public class COMPOSITION : LOCATABLE
{
    public required CODE_PHRASE language { get; set; }

    public override DV_Text Concept()
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

    public override Pathable? Parent()
    {
        throw new NotImplementedException();
    }

    public override bool PathExists(string path)
    {
        throw new NotImplementedException();
    }

    public override string? PathOfItem(Pathable locatable)
    {
        throw new NotImplementedException();
    }
}
