using static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes;

#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Reflection;

public sealed partial class Reflector
{
    public sealed partial class Type<T>
    {
        /// <summary>
        /// The cached <see cref="IsCoreType"/> value.
        /// </summary>
        private bool? _IsCoreType;

        /// <summary>
        /// Gets whether or not type <typeparamref name="T"/> is a type of core Const Type Args framework type.
        /// </summary>
        /// <value>
        /// A value of <see langword="true"/> if the specified type is a type of core Const Type Args framework type;
        /// otherwise, <see langword="false"/>.
        /// </value>
        /// <remarks>
        /// ...
        ///   <para>
        ///   This property dynamically accesses the interfaces of type <typeparamref name="T"/>.
        ///   </para>
        /// </remarks>
        /// <seealso cref="Reflector.IsCoreType(Type)"/>
        public static bool IsCoreType
            => Reflect.IsCoreTypeImpl();

        /// <summary>
        /// The implementation of the <see cref="IsCoreType"/> property.
        /// </summary>
        /// <returns>
        /// A value of <see langword="true"/> if the specified type is a type of core Const Type Args framework type;
        /// otherwise, <see langword="false"/>.
        /// </returns>
        private bool IsCoreTypeImpl()
            => _IsCoreType ??= Reflector.IsCoreType(typeof(T));
    }

    /// <summary>
    /// Returns whether or not the specified type is a type of core Const Type Args framework type.
    /// </summary>
    /// <param name="type">
    /// The type to check.
    /// </param>
    /// <returns>
    /// A value of <see langword="true"/> if the specified type is a type of core Const Type Args framework type;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    /// <remarks>
    /// ...
    ///   <para>
    ///   Use <see cref="Type{T}.IsCoreType"/> instead to cache the results of this method.
    ///   </para>
    ///   <para>
    ///   This method dynamically accesses the interfaces of the specified type.
    ///   </para>
    /// </remarks>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="type"/> is <see langword="null"/>.
    /// </exception>
    /// <seealso cref="Type{T}.IsCoreType"/>
    public static bool IsCoreType([DynamicallyAccessedMembers(Interfaces)] Type type)
        => Reflect.IsCoreTypeImpl(type);

    /// <summary>
    /// The implementation for the <see cref="IsCoreType"/> method.
    /// </summary>
    /// <param name="type">
    /// The type to check.
    /// </param>
    /// <returns>
    /// A value of <see langword="true"/> if the specified type is a type of
    /// core Const Type Args framework type;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="type"/> is <see langword="null"/>.
    /// </exception>
    private bool IsCoreTypeImpl([DynamicallyAccessedMembers(Interfaces)] Type type)
    {
        ArgumentNullException.ThrowIfNull(type, nameof(type));

        return false;
    }
}
