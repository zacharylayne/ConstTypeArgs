using static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes;

#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Reflection;

public sealed partial class Reflector
{
    public sealed partial class Type<T>
    {
        /// <summary>
        /// The cached <see cref="IsArgConsumer"/> value.
        /// </summary>
        private readonly Lazy<bool> _IsArgConsumer = new(
            () => Reflector.IsArgConsumer(typeof(T)));

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
        /// <seealso cref="Reflector.IsArgConsumer(Type)"/>
        public static bool IsArgConsumer
            => Reflect._IsArgConsumer.Value;

        /// <summary>
        /// The cached <see cref="ConstTypeParams"/> value.
        /// </summary>
        private readonly Lazy<Type[]> _ConstTypeParams = new(
            () => GetConstTypeParams(typeof(T)));

        /// <summary>
        /// Gets the constant type parameters for the type <typeparamref name="T"/>.
        /// </summary>
        /// <value>
        /// An array of constant type parameters for the type <typeparamref name="T"/>
        /// or an empty array if the type <typeparamref name="T"/> is not a type of argument consumer.
        /// </value>
        /// <remarks>
        /// This property dynamically accesses the interfaces of type <typeparamref name="T"/>.
        /// </remarks>
        /// <seealso cref="GetConstTypeParams(Type)"/>
        public static Type[] ConstTypeParams
            => Reflect._ConstTypeParams.Value;
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
    ///   Use <see cref="Type{T}.IsArgConsumer"/> instead to cache the results of this method.
    ///   </para>
    ///   <para>
    ///   This method dynamically accesses the interfaces of the specified type.
    ///   </para>
    /// </remarks>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="type"/> is <see langword="null"/>.
    /// </exception>
    /// <seealso cref="Type{T}.IsArgConsumer"/>
    public static bool IsArgConsumer([DynamicallyAccessedMembers(Interfaces)] Type type)
        => Reflect.IsArgConsumerImpl(type);

    /// <summary>
    /// The implementation for the <see cref="IsArgConsumer"/> method.
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
    private bool IsArgConsumerImpl([DynamicallyAccessedMembers(Interfaces)] Type type)
    {
        ArgumentNullException.ThrowIfNull(type, nameof(type));

        if (type.IsClosedGenericType())
        {
            foreach (var genericArgument in type.GetGenericArguments())
            {
                foreach (var constraint in genericArgument.GetGenericParameterConstraints())
                {
                    if (constraint.IsGenericType && constraint.GetGenericTypeDefinition() == typeof(IConstTypeArg<>))
                        return true;
                }
            }
        }

        return false;
    }

    /// <summary>
    /// Returns the constant type parameters for the specified type.
    /// </summary>
    /// <param name="type">
    /// The type to get the const type parameters for.
    /// </param>
    /// <returns>
    /// An array of constant type parameters for the specified type or an empty array if the specified type
    /// is not a type of argument consumer.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="type"/> is <see langword="null"/>.
    /// </exception>
    /// <remarks>
    /// A const generic parameter is a generic parameter that is constrained to be a const type argument
    /// <em>(i.e. implements <see cref="IConstTypeArg{T}"/>)</em>.
    /// <para>
    /// Use <see cref="Type{T}.ConstTypeParams"/> instead to cache the results of this method.
    /// </para>
    ///   <para>
    ///   This method dynamically accesses the interfaces of the specified type.
    ///   </para>
    /// </remarks>
    public static Type[] GetConstTypeParams([DynamicallyAccessedMembers(Interfaces)] Type type)
        => Reflect.GetConstTypeParamsImpl(type);

    /// <summary>
    /// The implementation for the <see cref="GetConstTypeParams"/> method.
    /// </summary>
    /// <param name="type">
    /// The type to get the const type parameters for.
    /// </param>
    /// <returns>
    /// An array of constant type parameters for the specified type or an empty array if the specified type
    /// is not a type of argument consumer.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="type"/> is <see langword="null"/>.
    /// </exception>
    private Type[] GetConstTypeParamsImpl([DynamicallyAccessedMembers(Interfaces)] Type type)
    {
        ArgumentNullException.ThrowIfNull(type, nameof(type));

        if (IsArgConsumerImpl(type))
        {
            return type.GetGenericArguments().Where(genericArgument =>
            {
                foreach (var constraint in genericArgument.GetGenericParameterConstraints())
                {
                    if (constraint.IsGenericType && constraint.GetGenericTypeDefinition() == typeof(IConstTypeArg<>))
                        return true;
                }

                return false;
            }).ToArray();
        }

        return [];
    }
}
