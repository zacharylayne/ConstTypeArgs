using static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes;

#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Reflection;

public sealed partial class Reflector
{
    public sealed partial class Type<T>
    {
        /// <summary>
        /// The cached <see cref="IsConstTypeParam"/> value.
        /// </summary>
        private readonly Lazy<bool> _IsConstTypeParam = new(
            () => Reflector.IsConstTypeParam(typeof(T)));

        /// <summary>
        /// Gets whether or not type <typeparamref name="T"/> is a type of const type generic parameter.
        /// </summary>
        /// <value>
        /// A value of <see langword="true"/> if the type <typeparamref name="T"/> is a type of const type generic parameter;
        /// otherwise, <see langword="false"/>.
        /// </value>
        /// <remarks>
        /// A type is considered a type of const type parameter if it is a generic parameter that is
        /// constrained to a type of const type argument <em>(i.e. any type that implements <see cref="IConstTypeArg{T}"/>)</em>.
        /// </remarks>
        /// <seealso cref="Reflector.IsConstTypeParam(Type)"/>
        /// <seealso cref="ConstTypeConstraints"/>
        public static bool IsConstTypeParam
            => Reflect._IsConstTypeParam.Value;

        /// <summary>
        /// The cached <see cref="ConstTypeConstraints"/> value.
        /// </summary>
        private readonly Lazy<Type[]> _ConstTypeConstraints = new(
            () => GetConstTypeConstraints(typeof(T)));

        /// <summary>
        /// Gets the const type constraints for the type <typeparamref name="T"/>.
        /// </summary>
        /// <value>
        /// An array of const type constraints for the type <typeparamref name="T"/> or an empty array if the type <typeparamref name="T"/>
        /// is not a type of const type parameter or has no const type constraints.
        /// </value>
        /// <remarks>
        /// A const type constraint is a generic parameter constraint that is a const type
        /// <em>(i.e. a type that implements <see cref="IConstTypeArg{T}"/></em>.
        /// </remarks>
        /// <seealso cref="IsConstTypeParam"/>
        /// <seealso cref="Reflector.IsConstTypeParam(Type)"/>
        public static Type[] ConstTypeConstraints
            => Reflect._ConstTypeConstraints.Value;
    }

    /// <summary>
    /// Returns whether or not the specified type is a type of const type parameter.
    /// </summary>
    /// <param name="type">
    /// The type to check.
    /// </param>
    /// <returns>
    /// A value of <see langword="true"/> if the specified type is a type of const type parameter;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="type"/> is <see langword="null"/>.
    /// </exception>
    /// <remarks>
    /// A type is considered a type of const type parameter if it is a generic parameter that is
    /// constrained to a type of const type argument <em>(i.e. any type that implements <see cref="IConstTypeArg{T}"/>)</em>.
    ///   <para>
    ///   Use <see cref="Type{T}.IsConstTypeParam"/> instead to cache the results of this method.
    ///   </para>
    ///   <para>
    ///   This method dynamically accesses the interfaces of the specified type.
    ///   </para>
    /// </remarks>
    /// <seealso cref="Type{T}.IsConstTypeParam"/>
    /// <seealso cref="GetConstTypeConstraints(Type)"/>
    public static bool IsConstTypeParam([DynamicallyAccessedMembers(Interfaces)] Type type)
        => Reflect.IsConstTypeParamImpl(type);

    /// <summary>
    /// The implementation for <see cref="IsConstTypeParam(Type)"/>.
    /// </summary>
    /// <param name="type">
    /// The type to check.
    /// </param>
    /// <returns>
    /// A value of <see langword="true"/> if the specified type is a type of const type parameter;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    private bool IsConstTypeParamImpl([DynamicallyAccessedMembers(Interfaces)] Type type)
    {
        ArgumentNullException.ThrowIfNull(type, nameof(type));

        return type.IsGenericParameter && type.GetGenericParameterConstraints().Any(
            type => type == typeof(IConstTypeArg<>));
    }

    /// <summary>
    /// Returns the const type constraints for the specified const type parameter.
    /// </summary>
    /// <param name="type">
    /// The type to get the const type constraints for.
    /// </param>
    /// <returns>
    /// An array of const type constraints for the specified const type parameter or an empty array if the specified type
    /// is not a type of const type parameter or has no const type constraints.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="type"/> is <see langword="null"/>.
    /// </exception>
    /// <remarks>
    /// A const type constraint is a generic parameter constraint that is a const type
    /// <em>(i.e. a type that implements <see cref="IConstTypeArg{T}"/></em>.
    ///   <para>
    ///   This method dynamically accesses the interfaces of the specified type.
    ///   </para>
    /// </remarks>
    /// <seealso cref="Type{T}.ConstTypeConstraints"/>
    /// <seealso cref="IsConstTypeParam(Type)"/>
    public static Type[] GetConstTypeConstraints([DynamicallyAccessedMembers(Interfaces)] Type type)
        => Reflect.GetConstTypeConstraintsImpl(type);

    /// <summary>
    /// The implementation for <see cref="GetConstTypeConstraints(Type)"/>.
    /// </summary>
    /// <param name="type">
    /// The type to get the const type constraints for.
    /// </param>
    /// <returns>
    /// An array of const type constraints for the specified const type parameter or an empty array if the specified type
    /// is not a type of const type parameter or has no const type constraints.
    /// </returns>
    /// <remarks>
    /// A const type constraint is a generic parameter constraint that is a const type
    /// <em>(i.e. a type that implements <see cref="IConstTypeArg{T}"/></em>.
    ///   <para>
    ///   This method dynamically accesses the interfaces of the specified type.
    ///   </para>
    /// </remarks>
    private Type[] GetConstTypeConstraintsImpl([DynamicallyAccessedMembers(Interfaces)] Type type)
    {
        ArgumentNullException.ThrowIfNull(type, nameof(type));

        if (type.IsGenericParameter)
            return type.GetGenericParameterConstraints().Where(type => type != typeof(IConstTypeArg<>)).ToArray();

        return [];
    }
}
