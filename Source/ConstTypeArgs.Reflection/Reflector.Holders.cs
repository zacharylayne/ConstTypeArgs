using static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes;

#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Reflection;

public sealed partial class Reflector
{
    public sealed partial class Type<T>
    {
        /// <summary>
        /// The cached <see cref="IsConstTypeHolder"/> value.
        /// </summary>
        private bool? _IsConstTypeHolder;

        /// <summary>
        /// Gets whether or not the type <typeparamref name="T"/> is a type of const type holder.
        /// </summary>
        /// <value>
        /// A value of <see langword="true"/> if the type <typeparamref name="T"/> is a type of const type holder;
        /// otherwise, <see langword="false"/>.
        /// </value>
        /// <remarks>
        /// A type is considered a type of const type holder if it implements <see cref="K{TArg}"/>,
        /// is not an open generic type, and is not an interface.
        ///   <para>
        ///   This property dynamically accesses the interfaces of type <typeparamref name="T"/>.
        ///   </para>
        /// </remarks>
        /// <seealso cref="Reflector.IsConstTypeArg(Type)"/>
        public static bool IsConstTypeHolder
            => Reflect.IsConstTypeHolderImpl();

        /// <summary>
        /// The implementation of the <see cref="IsConstTypeHolder"/> property.
        /// </summary>
        /// <returns>
        /// A value of <see langword="true"/> if the type <typeparamref name="T"/> is a type of const type holder;
        /// otherwise, <see langword="false"/>.
        /// </returns>
        private bool IsConstTypeHolderImpl()
            => _IsConstTypeHolder ??= Reflector.IsConstTypeHolder(typeof(T));
    }

    /// <summary>
    /// Returns whether or not the specified type is a type of const type holder.
    /// </summary>
    /// <param name="type">
    /// The type to check.
    /// </param>
    /// <returns>
    /// A value of <see langword="true"/> if the specified type is a type of const type holder;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    /// <remarks>
    /// A type is considered a type of const type holder if it implements <see cref="K{TArg}"/>,
    /// is not an open generic type, and is not an interface.
    ///   <para>
    ///   Use <see cref="Type{T}.IsConstTypeHolder"/> instead to cache the results of this method.
    ///   </para>
    ///   <para>
    ///   This method dynamically accesses the interfaces of the specified type.
    ///   </para>
    /// </remarks>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="type"/> is <see langword="null"/>.
    /// </exception>
    /// <seealso cref="Type{T}.IsConstTypeHolder"/>
    public static bool IsConstTypeHolder([DynamicallyAccessedMembers(Interfaces)] Type type)
        => Reflect.IsConstTypeHolderImpl(type);

    /// <summary>
    /// The implementation for the <see cref="IsConstTypeHolder"/> method.
    /// </summary>
    /// <param name="type">
    /// The type to check.
    /// </param>
    /// <returns>
    /// A value of <see langword="true"/> if the specified type is a type of const type discard;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    /// <remarks>
    /// A type is considered a type of const type holder if it implements <see cref="K{TArg}"/>,
    /// is not an open generic type, and is not an interface.
    /// </remarks>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="type"/> is <see langword="null"/>.
    /// </exception>
    private bool IsConstTypeHolderImpl([DynamicallyAccessedMembers(Interfaces)] Type type)
    {
        ArgumentNullException.ThrowIfNull(type, nameof(type));

        return !(type.IsInterface || type.IsGenericTypeDefinition)
             && type.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition()
                                      == typeof(K<>));
    }
}
