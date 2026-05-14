using Rm.Common.Archetyped;
using Rm.DataTypes.Text;

namespace Rm.Ehr.Composition.Content.Navigation;

public class SECTION : CONTENT_ITEM
{
    /// <summary>
    /// Ordered list of content items under this section, which may include:
    /// * more SECTIONs;
    /// * ENTRYs.
    /// </summary>
    public IEnumerable<CONTENT_ITEM> Items { get; set; } = [];

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
