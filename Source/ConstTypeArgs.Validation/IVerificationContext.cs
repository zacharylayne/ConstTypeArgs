namespace ConstTypeArgs.Validation;

/// <summary>
/// The <see cref="IVerificationContext"/> interface provides verification context
/// information for const type arguments and their consumers.
/// </summary>
/// <remarks>
/// Use this interface to provide information about the const type argument's
/// declaring type and the const type argument itself. This can be useful
/// for logging, debugging, building Roslyn diagnostics, and other purposes.
/// </remarks>
public interface IVerificationContext
{
    /// <summary>
    /// Gets the name of the declaring type <em>(i.e. the argument consumer)</em>.
    /// </summary>
    /// <value>
    /// The declaring type's name.
    /// </value>
    string DeclaringTypeName { get; }

    /// <summary>
    /// Gets the declaring type <em>(i.e. the argument consumer)</em>.
    /// </summary>
    /// <value>
    /// The declaring type.
    /// </value>
    Type DeclaringType { get; }

    /// <summary>
    /// Gets the name of the generic parameter <em>(i.e. the const type parameter)</em>.
    /// </summary>
    /// <value>
    /// The generic parameter's name.
    /// </value>
    string GenericParameterName { get; }

    /// <summary>
    /// Gets the generic parameter <em>(i.e. the const type parameter)</em>.
    /// </summary>
    /// <value>
    /// The generic parameter.
    /// </value>
    Type GenericParameterType { get; }

    /// <summary>
    /// Returns the const type argument as an <see langword="object"/>.
    /// </summary>
    /// <returns>
    /// The const type argument as an <see langword="object"/> or <see langword="null"/>
    /// if the value cannot be determined.
    /// </returns>
    /// <seealso cref="IVerificationContext{T}.ArgumentValue"/>
    object? GetArgumentValue();
}

/// <summary>
/// The <see cref="IVerificationContext{T}"/> interface provides verification context
/// information for const type arguments and their consumers.
/// </summary>
/// <typeparam name="T">
/// The type of value that is being verified.
/// </typeparam>
/// <remarks>
/// Use this interface to provide information about the const type argument's
/// declaring type and the const type argument itself. This can be useful
/// for logging, debugging, building Roslyn diagnostics, and other purposes.
/// </remarks>
public interface IVerificationContext<T>
    : IVerificationContext
{
    /// <summary>
    /// Gets the const type argument's value.
    /// </summary>
    /// <value>
    /// The const type argument's value or <see langword="null"/> if the value
    /// cannot be determined.
    /// </value>
    /// <seealso cref="IVerificationContext.GetArgumentValue"/>
    T? ArgumentValue { get; }
}
