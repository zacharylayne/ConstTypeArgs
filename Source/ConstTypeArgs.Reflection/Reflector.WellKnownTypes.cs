using static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes;

#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Reflection;

public sealed partial class Reflector
{
    public sealed partial class Type<T>
    {
        /// <summary>
        /// The cached <see cref="IsWellKnown"/> value.
        /// </summary>
        private bool? _IsWellKnown;

        /// <summary>
        /// Gets whether or not type <typeparamref name="T"/> if the type <typeparamref name="T"/>
        /// is a well-known Const Type Args framework type.
        /// </summary>
        /// <value>
        /// A value of <see langword="true"/> if the type <typeparamref name="T"/> is
        /// a well-known Const Type Args framework type;
        /// otherwise, <see langword="false"/>.
        /// </value>
        /// <remarks>
        /// Well-known Const Type Args framework types include core types and a set of other types representing
        /// const type arguments for primitive types, arrays, and a limited set of other types.
        /// The <see cref="WellKnownConstTypes"/> class contains a list of well-known const types.
        ///   <para>
        ///   This property dynamically accesses the interfaces of type <typeparamref name="T"/>.
        ///   </para>
        /// </remarks>
        /// <seealso cref="Reflector.IsWellKnown(Type)"/>
        /// <seealso cref="WellKnownConstTypes"/>
        public static bool IsWellKnown
            => Reflect.IsWellKnownImpl();

        /// <summary>
        /// The implementation of the <see cref="IsWellKnown"/> property.
        /// </summary>
        /// <returns>
        /// A value of <see langword="true"/> if the type <typeparamref name="T"/> is
        /// a well-known Const Type Args framework type;
        /// otherwise, <see langword="false"/>.
        /// </returns>
        private bool IsWellKnownImpl()
            => _IsWellKnown ??= Reflector.IsWellKnown(typeof(T));
    }

    /// <summary>
    /// Returns whether or not the specified type is a well-known Const Type Args framework type.
    /// </summary>
    /// <param name="type">
    /// The type to check.
    /// </param>
    /// <returns>
    /// A value of <see langword="true"/> if the specified type is a well-known Const Type Args framework type;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    /// <remarks>
    ///   Well-known Const Type Args framework types include core types and a set of other types representing
    ///   const type arguments for primitive types, arrays, and a limited set of other types.
    ///   The <see cref="WellKnownConstTypes"/> class contains a list of well-known const types.
    ///   <para>
    ///   Use <see cref="Type{T}.IsWellKnown"/> instead to cache the results of this method.
    ///   </para>
    ///   <para>
    ///   This method dynamically accesses the interfaces of the specified type.
    ///   </para>
    /// </remarks>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="type"/> is <see langword="null"/>.
    /// </exception>
    /// <seealso cref="Type{T}.IsWellKnown"/>
    /// <seealso cref="WellKnownConstTypes"/>
    public static bool IsWellKnown([DynamicallyAccessedMembers(Interfaces)] Type type)
        => Reflect.IsWellKnownImpl(type);

    /// <summary>
    /// The implementation for the <see cref="IsWellKnown"/> method.
    /// </summary>
    /// <param name="type">
    /// The type to check.
    /// </param>
    /// <returns>
    /// A value of <see langword="true"/> if the specified type is a well-known Const Type Args framework type;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="type"/> is <see langword="null"/>.
    /// </exception>
    private bool IsWellKnownImpl([DynamicallyAccessedMembers(Interfaces)] Type type)
    {
        ArgumentNullException.ThrowIfNull(type, nameof(type));

        return false;
    }
}
