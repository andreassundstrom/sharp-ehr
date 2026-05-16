namespace Odin.Odin;

public abstract class OdinNode { }

public class OdinMember
{
    public OdinMember(OdinNode value)
    {
        Value = value;
    }

    public OdinMember(string key, OdinNode value)
    {
        Key = key;
        Value = value;
    }

    public string? Key { get; set; }
    public OdinNode Value { get; set; }
}

public class OdinObject : OdinNode
{
    public string? ExplicitType { get; set; }
    public List<OdinMember> Members { get; } = new();
}

public class OdinValue : OdinNode
{
    public object? Value { get; }
    public OdinValue(object? value)
    {
        Value = value;
    }
}