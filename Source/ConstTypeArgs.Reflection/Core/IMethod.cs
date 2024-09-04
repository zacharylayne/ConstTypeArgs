namespace ConstTypeArgs.Reflection.Core;

/// <summary>
/// The <see cref="IMethod"/> interface provides access to method information.
/// </summary>
[EditorBrowsable(Never)]
public interface IMethod
{
    /// <summary>
    /// Gets information about the method.
    /// </summary>
    IMethodInfo Method { get; }
}
