namespace ConstTypeArgs.Reflection.Core;

/// <summary>
/// The <see cref="IDeclarable{T}"/> interface provides information about an element that is declared
/// within another element <em>(e.g. a type)</em>.
/// </summary>
/// <typeparam name="T">
/// The type of the element that declares the element.
/// </typeparam>
[EditorBrowsable(Never)]
public interface IDeclarable<T>
    where T : IElementInfo
{
    /// <summary>
    /// Gets a value indicating whether or not this element is declared within another element.
    /// </summary>
    /// <value>
    /// A value of <see langword="true"/> if this element is declared within another element;
    /// otherwise, <see langword="false"/>.
    /// </value>
    bool IsDeclared { get; }

    /// <summary>
    /// Gets the element that declares this element.
    /// </summary>
    /// <value>
    /// The element that declares this element or <see langword="null"/>
    /// if this element is not declared within another element.
    /// </value>
    T? Declarer { get; }
}
