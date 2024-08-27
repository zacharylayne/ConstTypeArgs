using static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes;

#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Reflection;

public sealed partial class Reflector
{
    public sealed partial class Type<T>
    {
        /// <summary>
        /// The cached <see cref="IsConstTypeDiscard"/> value.
        /// </summary>
        private readonly Lazy<bool> _IsConstTypeDiscard = new(
            () => Reflector.IsConstTypeDiscard(typeof(T)));

        /// <summary>
        /// Gets whether or not type <typeparamref name="T"/> is a type of const type discard.
        /// </summary>
        /// <value>
        /// A value of <see langword="true"/> if the type <typeparamref name="T"/> is a type of const type discard;
        /// otherwise, <see langword="false"/>.
        /// </value>
        /// <remarks>
        /// A type is considered a type of const type discard if it derives from <see cref="__"/>
        /// and is not an open generic type.
        ///   <para>
        ///   This property dynamically accesses the interfaces of type <typeparamref name="T"/>.
        ///   </para>
        /// </remarks>
        /// <seealso cref="Reflector.IsConstTypeDiscard(Type)"/>
        public static bool IsConstTypeDiscard
            => Reflect._IsConstTypeDiscard.Value;
    }

    /// <summary>
    /// Returns whether or not the specified type is a type of const type discard.
    /// </summary>
    /// <param name="type">
    /// The type to check.
    /// </param>
    /// <returns>
    /// A value of <see langword="true"/> if the specified type is a type of const type discard;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    /// <remarks>
    /// A type is considered a type of const type discard if it derives from <see cref="__"/>
    /// and is not an open generic type.
    ///   <para>
    ///   Use <see cref="Type{T}.IsConstTypeDiscard"/> instead to cache the results of this method.
    ///   </para>
    ///   <para>
    ///   This method dynamically accesses the interfaces of the specified type.
    ///   </para>
    /// </remarks>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="type"/> is <see langword="null"/>.
    /// </exception>
    /// <seealso cref="Type{T}.IsConstTypeDiscard"/>
    public static bool IsConstTypeDiscard([DynamicallyAccessedMembers(Interfaces)] Type type)
        => Reflect.IsConstTypeDiscardImpl(type);

    /// <summary>
    /// The implementation for the <see cref="IsConstTypeDiscard"/> method.
    /// </summary>
    /// <param name="type">
    /// The type to check.
    /// </param>
    /// <returns>
    /// A value of <see langword="true"/> if the specified type is a type of const type discard;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    /// <remarks>
    /// A type is considered a type of const type discard if it derives from <see cref="__"/>
    /// and is not an open generic type.
    /// </remarks>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="type"/> is <see langword="null"/>.
    /// </exception>
    private bool IsConstTypeDiscardImpl([DynamicallyAccessedMembers(Interfaces)] Type type)
    {
        ArgumentNullException.ThrowIfNull(type, nameof(type));

        return typeof(__).IsAssignableFrom(type);
    }
}
