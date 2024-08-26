using static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes;

#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Reflection;

public sealed partial class Reflector
{
    public sealed partial class Type<T>
    {
        /// <summary>
        /// The cached <see cref="IsConsumerType"/> value.
        /// </summary>
        private bool? _IsConsumerType;

        /// <summary>
        /// Gets whether or not type <typeparamref name="T"/> if the type <typeparamref name="T"/> is a generic type with type parameters
        /// constrained to be constant type arguments;
        /// </summary>
        /// <value>
        /// A value of <see langword="true"/> if the type <typeparamref name="T"/> is a generic type with type parameters
        /// constrained to be constant type arguments;
        /// otherwise, <see langword="false"/>.
        /// </value>
        /// <remarks>
        ///   <para>
        ///   This property dynamically accesses the interfaces of type <typeparamref name="T"/>.
        ///   </para>
        /// </remarks>
        /// <seealso cref="Reflector.IsConsumerType(Type)"/>
        public static bool IsConsumerType
            => Reflect.IsConsumerTypeImpl();

        /// <summary>
        /// The implementation of the <see cref="IsConsumerType"/> property.
        /// </summary>
        /// <returns>
        /// A value of <see langword="true"/> if the type <typeparamref name="T"/> is a generic type with type parameters
        /// constrained to be constant type arguments;
        /// otherwise, <see langword="false"/>.
        /// </returns>
        private bool IsConsumerTypeImpl()
            => _IsConsumerType ??= Reflector.IsConsumerType(typeof(T));
    }

    /// <summary>
    /// Returns whether or not the specified type is a generic type with type parameters
    /// constrained to be constant type arguments.
    /// </summary>
    /// <param name="type">
    /// The type to check.
    /// </param>
    /// <returns>
    /// A value of <see langword="true"/> if the specified type is a generic type with type parameters
    /// constrained to be constant type arguments;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    /// <remarks>
    ///   <para>
    ///   Use <see cref="Type{T}.IsConsumerType"/> instead to cache the results of this method.
    ///   </para>
    ///   <para>
    ///   This method dynamically accesses the interfaces of the specified type.
    ///   </para>
    /// </remarks>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="type"/> is <see langword="null"/>.
    /// </exception>
    /// <seealso cref="Type{T}.IsConsumerType"/>
    public static bool IsConsumerType([DynamicallyAccessedMembers(Interfaces)] Type type)
        => Reflect.IsConsumerTypeImpl(type);

    /// <summary>
    /// The implementation for the <see cref="IsConsumerType"/> method.
    /// </summary>
    /// <param name="type">
    /// The type to check.
    /// </param>
    /// <returns>
    /// A value of <see langword="true"/> if the specified type is a generic type with type parameters
    /// constrained to be constant type arguments;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="type"/> is <see langword="null"/>.
    /// </exception>
    private bool IsConsumerTypeImpl([DynamicallyAccessedMembers(Interfaces)] Type type)
    {
        ArgumentNullException.ThrowIfNull(type, nameof(type));

        return false;
    }
}
