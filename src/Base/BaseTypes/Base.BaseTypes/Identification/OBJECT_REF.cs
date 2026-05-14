using System.Text.RegularExpressions;

namespace Base.BaseTypes.Identification;

/// <summary>
/// Class describing a reference to another object, which may exist locally or be maintained outside the 
/// current namespace, e.g. in another service. Services are usually external, e.g. available in a LAN 
/// (including on the same host) or the internet via Corba, SOAP, or some other distributed protocol. 
/// However, in small systems they may be part of the same executable as the data containing the Id.
/// </summary>
public class OBJECT_REF
{
    /// <summary>
    /// Namespace to which this identifier belongs in the local system context (and possibly in any other 
    /// openEHR compliant environment) e.g. terminology , demographic . These names are not yet standardised.
    /// 
    /// Legal values for namespace are:
    /// - "local"
    /// - "unknown"
    /// - a string matching the standard regex[a - zA - Z][a - zA - Z0 - 9_.:\/ ?= +-]*.
    /// 
    /// Note that the first two are just special values of the regex, and will be matched by it.
    /// </summary>
    public required string Namespace { get; set; }

    /// <summary>
    /// Name of the class (concrete or abstract) of object to which this identifier type refers, 
    /// e.g. PARTY, PERSON, GUIDELINE etc. These class names are from the relevant reference model. 
    /// The type name ANY can be used to indicate that any type is accepted (e.g. if the type is unknown).
    /// </summary>
    public required string Type { get; set; }

    /// <summary>
    /// Globally unique id of an object, regardless of where it is stored.
    /// </summary>
    public required OBJECT_ID Id { get; set; }
}
