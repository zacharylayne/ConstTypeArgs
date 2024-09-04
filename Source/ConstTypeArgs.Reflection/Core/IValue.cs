namespace ConstTypeArgs.Reflection.Core;

/// <summary>
/// The <see cref="IValue"/> interface provides the means to retrieve a value from
/// a framework-related code element that has a value.
/// </summary>
[EditorBrowsable(Never)]
public interface IValue
{
    /// <summary>
    /// Gets whether or not the value of the code element is undefined.
    /// </summary>
    /// <value>
    /// A value of <see langword="true"/> if the value is undefined; otherwise, <see langword="false"/>.
    /// </value>
    /// <remarks>
    /// If this property is <see langword="true"/>, then any value, including <see langword="null"/>,
    /// is considered valid for <see cref="Value"/>. If this property is <see langword="false"/>,
    /// then <see cref="Value"/> should be treated as undefined, regardless of the actual value returned.
    /// </remarks>
    /// <seealso cref="Value"/>
    /// <seealso cref="TypeOfValue"/>
    bool HasValue { get; }

    /// <summary>
    /// Gets the value of the code element.
    /// </summary>
    /// <remarks>
    /// If <see cref="HasValue"/> is <see langword="false"/>, then this property should be
    /// considered undefined, regardless of the actual value returned. No exception should be thrown.
    /// </remarks>
    object? Value { get; }

    /// <summary>
    /// Gets the type of the code element's value.
    /// </summary>
    Type TypeOfValue { get; }

    /// <summary>
    /// Gets the value of the code element as a specified type.
    /// </summary>
    /// <typeparam name="T">
    /// The type to convert the value to.
    /// </typeparam>
    /// <returns>
    /// The value of the code element as the specified type.
    /// </returns>
    /// <remarks>
    /// If <see cref="HasValue"/> is <see langword="false"/>, then this method's
    /// return value should be considered undefined,
    /// regardless of the actual value returned. No exception should be thrown.
    /// </remarks>
    T? GetValueAs<T>();
}
