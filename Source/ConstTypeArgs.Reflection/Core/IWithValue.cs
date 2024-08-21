namespace ConstTypeArgs.Reflection.Core;

/// <summary>
/// The <see cref="IWithValue"/> interface provides the means to retrieve a value from
/// a framework-related code element that has a value.
/// </summary>
/// <seealso cref="IWithValue{T}"/>
[EditorBrowsable(Advanced)]
public interface IWithValue
{
    /// <summary>
    /// Gets the value of the code element.
    /// </summary>
    /// <remarks>
    /// If <see cref="IsValueDefined"/> is <see langword="false"/>, then this property should be
    /// considered undefined, regardless of the actual value returned, but no exception should be thrown.
    /// </remarks>
    object Value { get; }

    /// <summary>
    /// Gets the type of the code element's value.
    /// </summary>
    Type Type { get; }

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
    /// <seealso cref="Type"/>
    bool IsValueDefined { get; }
}

/// <summary>
/// The <see cref="IWithValue{T}"/> interface provides the means to retrieve a value from
/// a framework-related code element that has a value.
/// </summary>
/// <typeparam name="T">
/// The type of the code element's value.
/// </typeparam>
/// <seealso cref="IWithValue"/>
[EditorBrowsable(Advanced)]
public interface IWithValue<T>
{
    /// <summary>
    /// Gets the value of the code element.
    /// </summary>
    /// <remarks>
    /// If <see cref="IsValueDefined"/> is <see langword="false"/>, then this property should be
    /// considered undefined, regardless of the actual value returned, but no exception should be thrown.
    /// </remarks>
    T Value { get; }

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
    bool IsValueDefined { get; }
}