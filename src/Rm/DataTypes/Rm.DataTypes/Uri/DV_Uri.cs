using Rm.DataTypes.Basic;

namespace Rm.DataTypes.Uri;

/// <summary>
/// A reference to an object which structurally conforms to the Universal Resource Identifier (URI) RFC-3986 standard. 
/// The reference is contained in the value attribute, which is a String. So-called 'plain-text URIs' that contain RFC-3986 
/// forbidden characters such as spaces etc, are allowed on the basis that they need to be RFC-3986 encoded prior to use in e.g. 
/// REST APIs or other contexts relying on machine-level conformance.
/// </summary>
public class DV_Uri : Data_Value
{
    /// <summary>
    /// Value of URI as a String. 'Plain-text' URIs are allowed, enabling better readability, but must be RFC-3986 encoded in use.
    /// </summary>
    public required string value { get; set; }
}
