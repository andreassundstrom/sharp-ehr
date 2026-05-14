using Base.BaseTypes.Identification;

using Rm.DataStructures.ItemStructure;

namespace Rm.Ehr.Composition.Content.Entry;

/// <summary>
/// The abstract parent of all clinical ENTRY subtypes. A CARE_ENTRY defines protocol and guideline attributes for all clinical Entry subtypes.
/// </summary>
public abstract class CARE_ENTRY : ENTRY
{
    /// <summary>
    /// Description of the method(i.e.how) the information in this entry was arrived at.For 
    /// OBSERVATIONs, this is a description of the method or instrument used. For EVALUATIONs, 
    /// how the evaluation was arrived at. For INSTRUCTIONs, how to execute the Instruction.
    /// This may take the form of references to guidelines, including manually followed and 
    /// executable; knowledge references such as a paper in Medline; clinical reasons within 
    /// a larger care process.
    /// </summary>
    public ITEM_STRUCTURE? Protocol { get; set; }

    /// <summary>
    /// Optional external identifier of guideline creating this Entry if relevant.
    /// </summary>
    public OBJECT_REF? Guideline_Id { get; set; }
}
