namespace ConstTypeArgs.Reflection;

/// <summary>
/// The <see cref="Reflector"/> static class contains methods for reflecting on and collecting information
/// about kinds of framework types, such as const type arguments, const type parameters, argument consumers,
/// and others.
/// </summary>
/// <remarks>
/// If <see cref="Reflector"/> methods are being called often for a type, consider using
/// matching methods in <see cref="Type{T}"/> to cache data for the type.
/// </remarks>
/// <seealso cref="Type{T}"/>
public static partial class Reflector
{
    /// <summary>
    /// The <see cref="Type{T}"/> static class contains methods for reflecting on and caching
    /// information about the <typeparamref name="T"/> type.
    /// </summary>
    /// <typeparam name="T">
    /// The type to reflect on and cache information about.
    /// </typeparam>
    public static class Type<T>
    {
    }
}
