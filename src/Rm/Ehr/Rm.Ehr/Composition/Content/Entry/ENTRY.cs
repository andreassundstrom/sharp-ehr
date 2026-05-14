using Base.BaseTypes.Identification;

using Rm.Common.Generic;
using Rm.DataTypes.Text;

namespace Rm.Ehr.Composition.Content.Entry;

/// <summary>
/// The abstract parent of all ENTRY subtypes. An ENTRY is the root of a logical item of hard 
/// clinical information created in the clinical statement context, within a clinical session. 
/// There can be numerous such contexts in a clinical session. Observations and other Entry types 
/// only ever document information captured/created in the event documented by the enclosing Composition.
///
/// An ENTRY is also the minimal unit of information any query should return, since a whole 
/// ENTRY(including subparts) records spatial structure, timing information, and contextual 
/// information, as well as the subject and generator of the information.
/// </summary>
public abstract class ENTRY : CONTENT_ITEM
{
    public required CODE_PHRASE Language { get; set; }

    public required CODE_PHRASE Encoding { get; set; }

    public OBJECT_REF? Workflow_Id { get; set; }

    public required PARTY_PROXY Subject { get; set; }

    public PARTY_PROXY? Provider { get; set; }
}
