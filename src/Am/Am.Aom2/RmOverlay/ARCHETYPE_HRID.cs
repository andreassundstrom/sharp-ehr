using Base.BaseTypes.Definitions;

namespace Am.Aom2.RmOverlay;

/// <summary>
/// Human-readable structured identifier (HRID) for an archetype or template.
/// </summary>
public class ARCHETYPE_HRID
{
    /// <summary>
    /// Reverse domain name namespace identifier.
    /// </summary>
    public string? @namespace { get; set; }

    /// <summary>
    /// Name of the Reference Model publisher.
    /// </summary>
    public required string rm_publisher { get; set; }

    /// <summary>
    /// Name of the package in whose reachability graph 
    /// the rm_class class is found (there can be more than one possibility in many reference models).
    /// </summary>
    public required string rm_package { get; set; }

    /// <summary>
    /// Name of the root class of this archetype.
    /// </summary>
    public required string rm_class { get; set; }

    //The short concept name of the archetype as used in the multi-axial archetype_hrid.
    public required string concept_id { get; set; }


    /// <summary>
    /// The full numeric version of this archetype consisting of 3 parts,
    /// e.g. "1.8.2". The archetype_hrid feature includes only the major version.
    /// </summary>
    public required string release_version { get; set; }

    /// <summary>
    /// The status of the version, i.e.:
    /// - released: (empty string)
    /// - release_candidate: "rc"
    /// - alpha: "alpha"
    /// - beta: "beta"
    /// </summary>
    public required VERSION_STATUS version_status { get; set; }

    /// <summary>
    ///     The build count since last increment of any version part.
    /// </summary>
    public required string build_count { get; set; }



}
