namespace Base.BaseTypes.Identification;

/// <summary>
/// Identifier for archetypes. Ideally these would identify globally unique archetypes.

/// 
/// Lexical form: rm_originator '-' rm_name '-' rm_entity '.' concept_name { '-' specialisation }* '.v' number.
/// </summary>
public class ArchetypeId : ObjectId
{

    /// <summary>
    /// Globally qualified reference model entity, e.g.openehr-EHR-OBSERVATION.
    /// </summary>
    public string qualified_rm_entity()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Name of the concept represented by this archetype, including specialisation, e.g.Biochemistry_result-cholesterol.
    /// </summary>
    /// <returns></returns>
    public string domain_concept()
    {
        throw new NotImplementedException();

    }

    /// <summary>
    /// Organisation originating the reference model on which this archetype is based, e.g.openehr, cen, hl7.
    /// </summary>
    public string rm_originator()
    {
        throw new NotImplementedException();

    }

    /// <summary>
    /// Name of the reference model, e.g.rim, ehr_rm, en13606.
    /// </summary>
    public string rm_name()
    {
        throw new NotImplementedException();

    }

    /// <summary>
    /// Name of the ontological level within the reference model to which this archetype is targeted, e.g. for openEHR, folder , composition , section , entry.
    /// </summary>
    string rm_entity()
    {
        throw new NotImplementedException();

    }

    /// <summary>
    /// Name of specialisation of concept, if this archetype is a specialisation of another archetype, e.g.cholesterol.
    /// </summary>
    /// <returns></returns>
    public string specialisation()
    {
        throw new NotImplementedException();

    }

    /// <summary>
    /// Version of this archetype.
    /// </summary>
    public string version_id()
    {
        throw new NotImplementedException();

    }
}
