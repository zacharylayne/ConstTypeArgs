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

    /// <summary>
    /// Returns reflection information about the specified type.
    /// </summary>
    /// <returns>
    /// Reflection information about the specified type.
    /// </returns>
    public static ITypeInfo GetTypeInfo()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Returns reflection information about the specified const type argument.
    /// </summary>
    /// <returns>
    /// Reflection information about the specified const type argument.
    /// </returns>
    public static IConstTypeArgInfo GetConstTypeArgInfo()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Returns reflection information about the specified generic parameter.
    /// </summary>
    /// <returns>
    /// Reflection information about the specified generic parameter.
    /// </returns>
    public static IGenericParameterInfo GetGenericParameterInfo()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Returns reflection information about the specified attribute.
    /// </summary>
    /// <returns>
    /// Reflection information about the specified attribute.
    /// </returns>
    public static IAttributeInfo GetAttributeInfo()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Returns the value of the specified const type argument.
    /// </summary>
    /// <returns>
    /// The value of the specified const type argument as an object.
    /// </returns>
    public static object GetConstTypeArgValue()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Returns whether or not the specified type is a const type holder.
    /// </summary>
    /// <returns>
    /// A value of <see langword="true"/> if the specified type is a const type holder;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    /// <exception cref="NotImplementedException"></exception>
    public static bool IsConstTypeHolder()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Returns whether or not the specified type is a const type discard.
    /// </summary>
    /// <returns>
    /// A value of <see langword="true"/> if the specified type is a const type discard;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    public static bool IsConstTypeDiscard()
    {
        throw new NotImplementedException();
    }
}
