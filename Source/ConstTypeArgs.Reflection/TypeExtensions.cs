namespace ConstTypeArgs.Reflection;

/// <summary>
/// The <see cref="TypeExtensions"/> static class contains extension methods for reflecting on types.
/// </summary>
public static class TypeExtensions
{
    /// <summary>
    /// Returns whether or not this type is an attribute.
    /// </summary>
    /// <param name="type">
    /// This type.
    /// </param>
    /// <returns>
    /// A value of <see langword="true"/> if this type is an attribute;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    public static bool IsAttribute(this Type type)
        => type.IsSubclassOf(typeof(Attribute));

    /// <summary>
    /// Returns whether or not this type is an exception.
    /// </summary>
    /// <param name="type">
    /// This type.
    /// </param>
    /// <returns>
    /// A value of <see langword="true"/> if this type is an exception;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    public static bool IsException(this Type type)
        => type.IsSubclassOf(typeof(Exception));

    /// <summary>
    /// Returns whether or not this type is an open generic type.
    /// </summary>
    /// <param name="type">
    /// This type.
    /// </param>
    /// <returns>
    /// A value of <see langword="true"/> if this type is an open generic type;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    public static bool IsOpenGenericType(this Type type)
        => type.IsGenericType && !type.IsGenericTypeDefinition;

    /// <summary>
    /// Returns whether or not this type is a closed generic type.
    /// </summary>
    /// <param name="type">
    /// This type.
    /// </param>
    /// <returns>
    /// A value of <see langword="true"/> if this type is a closed generic type;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    public static bool IsClosedGenericType(this Type type)
        => type.IsGenericType && type.IsGenericTypeDefinition;
}
