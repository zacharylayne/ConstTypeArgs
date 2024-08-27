using System.Reflection;

using static System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes;
using static System.Reflection.BindingFlags;

#pragma warning disable RCS1158 // Static member in generic type should use a type parameter

namespace ConstTypeArgs.Reflection;

public sealed partial class Reflector
{
    public sealed partial class Type<T>
    {
        /// <summary>
        /// The cached <see cref="Type{T}.ValueProperty"/> value.
        /// </summary>
        private readonly Lazy<PropertyInfo?> _ValueProperty = new(
            () => GetValueProperty(typeof(T)));

        /// <summary>
        /// Gets the <see cref="IConstTypeArg{T}.Value"/> property of the type <typeparamref name="T"/>.
        /// </summary>
        /// <value>
        /// The <see cref="IConstTypeArg{T}.Value"/> property of the type <typeparamref name="T"/>,
        /// if it exists; otherwise, <see langword="null"/>.
        /// </value>
        /// <remarks>
        /// </remarks>
        public static PropertyInfo? ValueProperty
            => Reflect._ValueProperty.Value;

        /// <summary>
        /// The cached <see cref="Type{T}.TypeOfValue"/> value.
        /// </summary>
        private readonly Lazy<Type?> _TypeOfValue = new(
            () => GetTypeOfValue(typeof(T)));

        /// <summary>
        /// Gets the type of the value for the type <typeparamref name="T"/>.
        /// </summary>
        /// <value>
        /// The type of the value for the type <typeparamref name="T"/>
        /// or <see langword="null"/> if the type <typeparamref name="T"/> is not a const type argument
        /// or if the value is not accessible.
        /// </value>
        public static Type? TypeOfValue
            => Reflect._TypeOfValue.Value;

        /// <summary>
        /// The cached <see cref="Type{T}.Value"/> value.
        /// </summary>
        private readonly Lazy<object?> _Value = new(
            () => GetValue(typeof(T)));

        /// <summary>
        /// Gets the value of the type <typeparamref name="T"/> as an object.
        /// </summary>
        /// <value>
        /// The value of type <typeparamref name="T"/> as an object or <see langword="null"/> if type <typeparamref name="T"/>
        /// is not a const type argument or if the value is not accessible.
        /// </value>
        /// <seealso cref="IConstTypeArg{T}.Value"/>
        public static object? Value
            => Reflect._Value.Value;
    }

    /// <summary>
    /// Returns the <see cref="IConstTypeArg{T}.Value"/> property of the specified type.
    /// </summary>
    /// <param name="type">
    /// The type to get the property of.
    /// </param>
    /// <returns>
    /// The <see cref="IConstTypeArg{T}.Value"/> property of the specified type, if it exists;
    /// otherwise, <see langword="null"/>.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="type"/> is <see langword="null"/>.
    /// </exception>
    /// <exception cref="AmbiguousMatchException">
    /// Thrown when binding to a member results in more than one member matching the binding criteria.
    /// </exception>
    /// <remarks>
    /// Use <see cref="Type{T}.ValueProperty"/> instead to cache the results of this method.
    ///   <para>
    ///   This method dynamically accesses the interfaces and public properties of the specified type.
    ///   </para>
    /// </remarks>
    /// <seealso cref="IConstTypeArg{T}.Value"/>
    /// <seealso cref="Type{T}.ValueProperty"/>
    /// <seealso cref="GetValue(Type)"/>
    public static PropertyInfo? GetValueProperty([DynamicallyAccessedMembers(Interfaces | PublicProperties)] Type type)
        => Reflect.GetValuePropertyImpl(type);

    /// <summary>
    /// The implementation for <see cref="GetValueProperty(Type)"/>.
    /// </summary>
    /// <param name="type">
    /// The type to get the property of.
    /// </param>
    /// <returns>
    /// The <see cref="IConstTypeArg{T}.Value"/> property of the specified type, if it exists;
    /// otherwise, <see langword="null"/>.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="type"/> is <see langword="null"/>.
    /// </exception>
    /// <exception cref="AmbiguousMatchException">
    /// Thrown when binding to a member results in more than one member matching the binding criteria.
    /// </exception>
    /// <remarks>
    /// This method dynamically accesses the interfaces and public properties of the specified type.
    /// </remarks>
    private PropertyInfo? GetValuePropertyImpl([DynamicallyAccessedMembers(Interfaces | PublicProperties)] Type type)
    {
        ArgumentNullException.ThrowIfNull(type, nameof(type));

        if (Reflect.IsConstTypeArgImpl(type))
            return type.GetProperty(ConstTypeArgValueMember, Static | Public);

        return default;
    }

    /// <summary>
    /// Returns the type of the value for the specified type.
    /// </summary>
    /// <param name="type">
    /// The type to get the type of the value of.
    /// </param>
    /// <returns>
    /// The type of the value for the specified type or <see langword="null"/> if the specified type is not a const type argument
    /// or if the value is not accessible.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="type"/> is <see langword="null"/>.
    /// </exception>
    /// <exception cref="AmbiguousMatchException">
    /// Thrown when binding to a member results in more than one member matching the binding criteria.
    /// </exception>
    /// <remarks>
    /// A const type argument's value is the value of the <see cref="IConstTypeArg{T}.Value"/> property.
    ///   <para>
    ///   Use <see cref="Type{T}.TypeOfValue"/> instead to cache the results of this method.
    ///   </para>
    ///   <para>
    ///   This method dynamically accesses the interfaces and public properties of the specified type.
    ///   </para>
    /// </remarks>
    /// <seealso cref="Type{T}.TypeOfValue"/>
    /// <seealso cref="GetValue(Type)"/>
    /// <seealso cref="IConstTypeArg{T}.Value"/>
    public static Type? GetTypeOfValue([DynamicallyAccessedMembers(Interfaces | PublicProperties)] Type type)
        => Reflect.GetTypeOfValueImpl(type);

    /// <summary>
    /// The implementation for <see cref="GetTypeOfValue(Type)"/>.
    /// </summary>
    /// <param name="type">
    /// The type to get the type of the value of.
    /// </param>
    /// <returns>
    /// The type of the value for the specified type or <see langword="null"/> if the specified type is not a const type argument
    /// or if the value is not accessible.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="type"/> is <see langword="null"/>.
    /// </exception>
    /// <exception cref="AmbiguousMatchException">
    /// Thrown when binding to a member results in more than one member matching the binding criteria.
    /// </exception>
    /// <remarks>
    /// This method dynamically accesses the interfaces and public properties of the specified type.
    /// </remarks>
    private Type? GetTypeOfValueImpl([DynamicallyAccessedMembers(Interfaces | PublicProperties)] Type type)
    {
        ArgumentNullException.ThrowIfNull(type, nameof(type));

        return GetValueProperty(type)?.PropertyType;
    }

    /// <summary>
    /// Returns the value of the specified type as an object.
    /// </summary>
    /// <param name="type">
    /// The type to get the value of.
    /// </param>
    /// <returns>
    /// The value of the specified type as an object or <see langword="null"/> if the specified type is not a const type argument
    /// or if the value is not accessible.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="type"/> is <see langword="null"/>.
    /// </exception>
    /// <exception cref="AmbiguousMatchException">
    /// Thrown when binding to a member results in more than one member matching the binding criteria.
    /// </exception>
    /// <remarks>
    ///  Use <see cref="Type{T}.Value"/> instead to cache the results of this method.
    ///   <para>
    ///   This method dynamically accesses the interfaces and public properties of the specified type.
    ///   </para>
    /// </remarks>
    /// <seealso cref="IConstTypeArg{T}.Value"/>
    /// <seealso cref="Type{T}.Value"/>
    /// <seealso cref="GetValueProperty(Type)"/>
    public static object? GetValue([DynamicallyAccessedMembers(Interfaces | PublicProperties)] Type type)
        => Reflect.GetValueImpl(type);

    /// <summary>
    /// The implementation for <see cref="GetValue(Type)"/>.
    /// </summary>
    /// <param name="type">
    /// The type to get the value of.
    /// </param>
    /// <returns>
    /// The value of the specified type as an object or <see langword="null"/> if the specified type is not a const type argument
    /// or if the value is not accessible.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="type"/> is <see langword="null"/>.
    /// </exception>
    /// <exception cref="AmbiguousMatchException">
    /// Thrown when binding to a member results in more than one member matching the binding criteria.
    /// </exception>
    /// <remarks>
    /// This method dynamically accesses the interfaces and public properties of the specified type.
    /// </remarks>
    private object? GetValueImpl([DynamicallyAccessedMembers(Interfaces | PublicProperties)] Type type)
    {
        ArgumentNullException.ThrowIfNull(type, nameof(type));

        return GetValueProperty(type)?.GetValue(default);
    }

    /// <summary>
    /// Returns the value of the specified type as type <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">
    /// The type to convert the value to.
    /// </typeparam>
    /// <param name="type">
    /// The type to get the value of.
    /// </param>
    /// <returns>
    /// The value of the specified type as type <typeparamref name="T"/> or <see langword="null"/>
    /// if the value can't be converted to <typeparamref name="T"/>.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="type"/> is <see langword="null"/>.
    /// </exception>
    /// <remarks>
    ///   <para>
    ///   This method dynamically accesses interfaces and public properties of the specified type.   
    ///   </para>
    /// </remarks>
    /// <seealso cref="Type{T}.Value"/>
    /// <seealso cref="IConstTypeArg{T}.Value"/>
    public static T? GetValueAs<T>([DynamicallyAccessedMembers(Interfaces | PublicProperties)] Type type)
        => Reflect.GetValueAsImpl<T>(type);

    // #TODO: Figure out how to appropriately handle Value being null and what to do if it can't be cast to T.

    /// <summary>
    /// The implementation for <see cref="GetValueAs{T}(Type)"/>.
    /// </summary>
    /// <typeparam name="T">
    /// The type to convert the value to.
    /// </typeparam>
    /// <param name="type">
    /// The type to get the value of.
    /// </param>
    /// <returns>
    /// The value of the specified type as type <typeparamref name="T"/> or <see langword="null"/>
    /// if the value can't be converted to <typeparamref name="T"/>.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="type"/> is <see langword="null"/>.
    /// </exception>
    private T? GetValueAsImpl<T>([DynamicallyAccessedMembers(Interfaces | PublicProperties)] Type type)
    {
        ArgumentNullException.ThrowIfNull(type, nameof(type));

        var value = GetValueImpl(type);

        if (value is T result)
            return result;

        return default;
    }
}
