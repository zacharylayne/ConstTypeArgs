using System.Diagnostics;
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
        private readonly Lazy<bool> _IsConstTypeHolder = new(
            () => Reflector.IsConstTypeHolder(typeof(T)));

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
        /// <seealso cref="ConstTypeArgHeld"/>
        public static bool IsConstTypeHolder
            => Reflect._IsConstTypeHolder.Value;

        /// <summary>
        /// The cached <see cref="ConstTypeArgHeld"/> value.
        /// </summary>
        private readonly Lazy<Type?> _ConstTypeArgHeld = new(
            () => GetConstTypeArgHeld(typeof(T)));

        /// <summary>
        /// Gets the const type argument held by the type <typeparamref name="T"/>.
        /// </summary>
        /// <value>
        /// The const type argument held by the type <typeparamref name="T"/> or <see langword="null"/>
        /// if the type <typeparamref name="T"/> is not a type of const type holder.
        /// </value>
        /// <remarks>
        /// This property dynamically accesses the interfaces of type <typeparamref name="T"/>.
        /// </remarks>
        /// <seealso cref="IsConstTypeHolder"/>
        public static Type? ConstTypeArgHeld
            => Reflect._ConstTypeArgHeld.Value;
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

    // #QUESTION: Are there use cases where the const type holder is an open generic type?

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

        return !type.IsInterface && type.IsClosedGenericType()
             && type.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition()
                                      == typeof(K<>));
    }

    /// <summary>
    /// Returns the const type argument held by the specified const type holder.
    /// </summary>
    /// <param name="type">
    /// The const type holder to get the const type argument from.
    /// </param>
    /// <returns>
    /// The const type argument held by the specified const type holder or <see langword="null"/>
    /// if the specified type is not a const type holder.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="type"/> is <see langword="null"/>.
    /// </exception>
    public static Type? GetConstTypeArgHeld([DynamicallyAccessedMembers(Interfaces)] Type type)
        => Reflect.ConstTypeArgHeldImpl(type);

    /// <summary>
    /// The implementation for the <see cref="GetConstTypeArgHeld"/> method.
    /// </summary>
    /// <param name="type">
    /// The const type holder to get the const type argument from.
    /// </param>
    /// <returns>
    /// The const type argument held by the specified const type holder or <see langword="null"/>
    /// if the specified type is not a const type holder.
    /// </returns>
    /// <remarks>
    /// To get the const type argument held by a const type holder, the specified type must implement
    /// <see cref="K{TArg}"/>. If the specified type implements multiple const type holders, this method
    /// will return the first const type argument held by the specified type.
    ///   <para>
    ///   This method dynamically accesses the interfaces of the specified type.
    ///   </para>
    /// </remarks>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="type"/> is <see langword="null"/>.
    /// </exception>
    private Type? ConstTypeArgHeldImpl([DynamicallyAccessedMembers(Interfaces)] Type type)
    {
        ArgumentNullException.ThrowIfNull(type, nameof(type));

        if (IsConstTypeHolderImpl(type))
        {
#if DEBUG
            if (ImplementsMultipleHolders(type))
                Debug.WriteLine(string.Format(ImplementsMultipleHoldersWarningMsg, type));

#endif
            var k = type.GetInterfaces().FirstOrDefault(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(K<>));

            return k?.GetGenericArguments().FirstOrDefault();
        }

        return default;
    }

    /// <summary>
    /// Returns whether or not the specified type implements multiple const type holders.
    /// </summary>
    /// <param name="type">
    /// The type to check.
    /// </param>
    /// <returns>
    /// A value of <see langword="true"/> if the specified type implements multiple const type holders;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="type"/> is <see langword="null"/>.
    /// </exception>
    private bool ImplementsMultipleHolders([DynamicallyAccessedMembers(Interfaces)] Type type)
    {
        ArgumentNullException.ThrowIfNull(type, nameof(type));

        // Using Take(2) to avoid iterating through all interfaces.
        return type.GetInterfaces().Take(2).Count(i
            => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(K<>)) > 1;
    }
}
