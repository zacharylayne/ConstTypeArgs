using static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes;

#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Reflection;

public sealed partial class Reflector
{
    public sealed partial class Type<T>
    {
        /// <summary>
        /// The cached <see cref="IsConstTypeArg"/> value.
        /// </summary>
        private bool? _IsConstTypeArg;

        /// <summary>
        /// Gets whether or not type <typeparamref name="T"/> is a type of const type argument.
        /// </summary>
        /// <value>
        /// A value of <see langword="true"/> if the type <typeparamref name="T"/> is a type of const type argument;
        /// otherwise, <see langword="false"/>.
        /// </value>
        /// <remarks>
        /// A type is considered a type of const type argument if it implements <see cref="IConstTypeArg{T}"/>,
        /// is not an interface, and is not an open generic type.
        ///   <para>
        ///   This property dynamically accesses the interfaces of type <typeparamref name="T"/>.
        ///   </para>
        /// </remarks>
        /// <seealso cref="Reflector.IsConstTypeArg(Type)"/>
        public static bool IsConstTypeArg
            => Reflect.IsConstTypeArgImpl();

        /// <summary>
        /// The implementation of the <see cref="IsConstTypeArg"/> property.
        /// </summary>
        /// <returns>
        /// A value of <see langword="true"/> if the type <typeparamref name="T"/> is a type of const type argument;
        /// otherwise, <see langword="false"/>.
        /// </returns>
        private bool IsConstTypeArgImpl()
            => _IsConstTypeArg ??= Reflector.IsConstTypeArg(typeof(T));
    }

    /// <summary>
    /// Returns whether or not the specified type is a type of const type argument.
    /// </summary>
    /// <param name="type">
    /// The type to check.
    /// </param>
    /// <returns>
    /// A value of <see langword="true"/> if the specified type is a type of const type argument;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    /// <remarks>
    /// A type is considered a type of const type argument if it implements <see cref="IConstTypeArg{T}"/>,
    /// is not an interface, and is not an open generic type.
    ///   <para>
    ///   Use <see cref="Type{T}.IsConstTypeArg"/> instead to cache the results of this method.
    ///   </para>
    ///   <para>
    ///   This method dynamically accesses the interfaces of the specified type.
    ///   </para>
    /// </remarks>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="type"/> is <see langword="null"/>.
    /// </exception>
    /// <seealso cref="Type{T}.IsConstTypeArg"/>
    public static bool IsConstTypeArg([DynamicallyAccessedMembers(Interfaces)] Type type)
        => Reflect.IsConstTypeArgImpl(type);

    /// <summary>
    /// The implementation for the <see cref="IsConstTypeArg"/> method.
    /// </summary>
    /// <param name="type">
    /// The type to check.
    /// </param>
    /// <returns>
    /// A value of <see langword="true"/> if the specified type is a type of const type argument;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    /// <remarks>
    /// A type is considered a type of const type argument if it implements <see cref="IConstTypeArg{T}"/>,
    /// is not an interface, and is not an open generic type.
    /// </remarks>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="type"/> is <see langword="null"/>.
    /// </exception>
    private bool IsConstTypeArgImpl([DynamicallyAccessedMembers(Interfaces)] Type type)
    {
        ArgumentNullException.ThrowIfNull(type, nameof(type));

        return !(type.IsInterface || type.IsGenericTypeDefinition)
             && type.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition()
                                      == typeof(IConstTypeArg<>));
    }
}
