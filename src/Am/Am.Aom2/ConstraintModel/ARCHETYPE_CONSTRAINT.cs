using Am.Aom2.Definitions;

namespace Am.Aom2.ConstraintModel;

public abstract class ARCHETYPE_CONSTRAINT : ADL_CODE_DEFINITIONS
{
    /// <summary>
    /// Parent node, except in the case of the top of a tree, i.e. root C_COMPLEX_OBJECT of an archetype definition.
    /// </summary>
    public ARCHETYPE_CONSTRAINT? parent { get; set; }
    public C_SECOND_ORDER? soc_parent { get; set; }

}
