namespace ConstTypeArgs.Sbytes;

/// <summary>
/// The <see cref="__"/> interface provides a const type argument that can be used as a value-less
/// "discard" in type parameter lists to provide union-like behavior. Its value should not be used.
/// </summary>
/// <remarks>
/// Types can implement this interface and other "discard" interfaces to satisfy constraints that can
/// be used as value-less discard types in type parameter lists.
/// </remarks>
public interface __ : Core.__, K_Sbyte
{
    /// <summary>
    /// A value equal to <see langword="default"/> that should that is not meant to be used.
    /// </summary>
    new public static sbyte Value => default;
}
