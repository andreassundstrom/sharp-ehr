namespace Rm.Common.Archetyped;

/// <summary>
/// Pathable can locate child objects using paths and know their parent object in a compositional hierarchy.
/// </summary>
public abstract class Pathable
{
    /// <summary>
    /// Get the parent of this object
    /// </summary>
    /// <returns>A parent (if any exists)</returns>
    public abstract Pathable? Parent();
    
    /// <summary>
    /// Returns the child item at a path
    /// </summary>
    /// <param name="path"></param>
    /// <returns>A child item (if any exists)</returns>
    public abstract object? ItemAtPath(string path);
    
    /// <summary>
    /// Returns an enumerable of child items at a path
    /// </summary>
    /// <param name="path"></param>
    /// <returns>Items at a specific path</returns>
    public abstract IEnumerable<object> ItemsAtPath(string path);

    /// <summary>
    /// Determines if a child path exists
    /// </summary>
    /// <param name="path"></param>
    /// <returns>true if the path exists</returns>
    public abstract bool PathExists(string path);

    /// <summary>
    /// Returns the path of a certain child object or null if it does not exist
    /// </summary>
    /// <param name="locatable"></param>
    /// <returns>The path of the object (if it is a child of the current object)</returns>
    public abstract string? PathOfItem(Pathable locatable);
}