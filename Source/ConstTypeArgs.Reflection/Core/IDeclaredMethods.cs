namespace ConstTypeArgs.Reflection.Core;

/// <summary>
/// The <see cref="IDeclaredMethods"/> interface provides information about a code element that has methods
/// declared.
/// </summary>
[EditorBrowsable(Never)]
public interface IDeclaredMethods
{
    /// <summary>
    /// Gets a value indicating whether or not the code element has methods declared.
    /// </summary>
    /// <value>
    /// A value of <see langword="true"/> if the code element has methods declared.
    /// otherwise, <see langword="false"/>.
    /// </value>
    bool HasDeclaredMethods { get; }

    /// <summary>
    /// Gets the methods the current code element declares.
    /// </summary>
    /// <value>
    /// If the code element does not declare any methods, an empty collection is returned instead.
    /// </value>
    IEnumerable<IMethodInfo> DeclaredMethods { get; }
}
