namespace ConstTypeArgs.Reflection.Core;

/// <summary>
/// The <see cref="INamespace"/> interface provides information about the namespace
/// a framework-related code element belongs to.
/// </summary>
[EditorBrowsable(Never)]
public interface INamespace
{
    /// <summary>
    /// Gets the name of the namespace that the code element belongs to.
    /// </summary>
    string Namespace { get; }
}
