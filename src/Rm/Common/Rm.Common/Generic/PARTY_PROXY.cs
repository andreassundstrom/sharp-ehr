using Base.BaseTypes.Identification;

namespace Rm.Common.Generic;

/// <summary>
/// Abstract concept of a proxy description of a party, including an optional link to 
/// data for this party in a demographic or other identity management system. Sub- typed into 
/// PARTY_IDENTIFIED and PARTY_SELF.
/// </summary>
public abstract class PARTY_PROXY
{
    /// <summary>
    /// Optional reference to more detailed demographic or identification information for this party, in an external system.
    /// </summary>
    public PARTY_REF? External_Ref { get; set; }
}
