namespace Rm.DataTypes.Uri;

/// <summary>
/// A DV_EHR_URI is a DV_URI which has the scheme name 'ehr', and which can only reference items in EHRs.
///
/// Used to reference items in an EHR, which may be the same as the current EHR(containing this link), or another.
/// </summary>
public class DV_Ehr_Uri : DV_Uri
{

}
