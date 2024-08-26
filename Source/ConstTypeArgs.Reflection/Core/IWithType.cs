namespace ConstTypeArgs.Reflection.Core;

/// <summary>
/// The <see cref="IWithType"/> interface is used to provide information about a type.
/// </summary>
public interface IWithType
{
    /// <summary>
    /// Gets the type this represents.
    /// </summary>
    Type Type { get; }
}