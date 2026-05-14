namespace Rm.DataTypes.Text;

/// <summary>
/// A text item, which may contain any amount of legal characters arranged as e.g.words, sentences 
/// etc(i.e.one DV_TEXT may be more than one word). Visual formatting and hyperlinks may be included 
/// via markdown.
///
/// If the formatting field is set, the value field is affected as follows:
/// * formatting = "plain": plain text, may contain newlines;
/// * formatting = "plain_no_newlines": plain text with no newlines;
/// * formatting = "markdown": text in markdown format; use of CommonMark strongly recommended.
///
/// A DV_TEXT can be coded by adding mappings to it.
/// </summary>
public class DV_Text
{
    public required string Value { get; set; }
}
