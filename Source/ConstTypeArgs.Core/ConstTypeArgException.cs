using System.Text;

namespace ConstTypeArgs;

/// <summary>
/// The <see cref="ConstTypeArgException"/> class is used to throw exceptions when an operation is attempted
/// using a const type argument and unrecoverably fails.
/// </summary>
/// <remarks>
/// Use the <see cref="Throw(Type, object?, bool, string?, Exception?)"/> and <see cref="Throw{T, K}(string?, Exception?)"/>
/// static methods to throw this exception.
/// </remarks>
public class ConstTypeArgException
    : ConstTypeException
{
    /// <summary>
    /// The default description format for the exception.
    /// </summary>
    /// <seealso cref="ConstTypeException.FormatDefaultMessage"/>
    private static readonly CompositeFormat DefaultDescriptionFormat
        = CompositeFormat.Parse($"{nameof(ConstTypeArgException)}, const arg: {{0}} value: {{1}}");

    /// <summary>
    /// Required. Gets &amp; inits the value of the const type argument associated with this exception.
    /// </summary>
    public required object? ArgValue { get; init; }

    /// <summary>
    /// Initializes a new <see cref="ConstTypeArgException"/> instance.
    /// </summary>
    protected ConstTypeArgException() { }

    /// <summary>
    /// Initializes a new <see cref="ConstTypeArgException"/> instance with the specified error message.
    /// </summary>
    /// <param name="message">
    /// The message explaining the cause of the exception.
    /// </param>
    protected ConstTypeArgException(string message)
        : base(message) { }

    /// <summary>
    /// Initializes a new <see cref="ConstTypeArgException"/> instance with the specified error message
    /// and a reference to the inner exception that caused this one to be thrown.
    /// </summary>
    /// <param name="message">
    /// The message explaining the cause of the exception.
    /// </param>
    /// <param name="innerException">
    /// The exception that is the cause of the current exception.
    /// </param>
    protected ConstTypeArgException(string message, Exception innerException)
        : base(message, innerException) { }

    /// <summary>
    /// Throws a new <see cref="ConstTypeArgException"/> with the specified parameters.
    /// </summary>
    /// <param name="type">
    /// The const type arg causing the exception to be thrown.
    /// </param>
    /// <param name="value">
    /// Optional. The const type argument's value.
    /// </param>
    /// <param name="isUndefined">
    /// Optional. Indicates that the const type argument has no value. This value is only used if <paramref name="value"/>
    /// is not provided or is <see langword="null"/>. If so, the displayed value is <c>UNDEFINED</c>.
    /// The default is <see langword="false"/>.
    /// </param>
    /// <param name="message">
    /// Optional. The message explaining the cause of the exception.
    /// </param>
    /// <param name="innerException">
    /// Optional. The exception that is the cause of the current exception.
    /// </param>
    /// <exception cref="ConstTypeArgException"/>
    /// <seealso cref="Throw{T, K}(string?, Exception?)"/>
    [DoesNotReturn]
    public static void Throw(Type type, object? value = default, bool isUndefined = false, string? message = default,
        Exception? innerException = default)
    {
        if (value is not null)
            message ??= FormatDefaultMessage(DefaultDescriptionFormat, type.Name, value);
        else if (isUndefined)
            message ??= FormatDefaultMessage(DefaultDescriptionFormat, type.Name, "UNDEFINED");
        else
            message ??= FormatDefaultMessage(DefaultDescriptionFormat, type.Name, "null");

        if (innerException is not null)
        {
            throw new ConstTypeArgException(message, innerException)
            {
                Type = type,
                ArgValue = value
            };
        }

        throw new ConstTypeArgException(message)
        {
            Type = type,
            ArgValue = value
        };
    }

    /// <summary>
    /// Throws an exception for a const type argument <typeparamref name="K"/> with the specified parameters.
    /// </summary>
    /// <typeparam name="T">
    /// The type of the value of the const type argument associated with the exception.
    /// </typeparam>
    /// <typeparam name="K">
    /// The const type argument associated with the exception.
    /// </typeparam>
    /// <param name="message">
    /// Optional. The message explaining the cause of the exception.
    /// </param>
    /// <param name="innerException">
    /// Optional. The exception that is the cause of the current exception.
    /// </param>
    /// <remarks>
    /// If the const type argument <typeparamref name="K"/> has no value, the displayed value is <c>UNDEFINED</c>.
    /// </remarks>
    /// <exception cref="ConstTypeArgException"/>
    /// <seealso cref="Throw(Type, object?, bool, string?, Exception?)"/>
    [DoesNotReturn]
    public static void Throw<T, K>(string? message = default, Exception? innerException = default)
        where K : IConstTypeArg<T>
    {
        string? value = "";

        try
        {
            if (K.Value is null)
                value = "null";
            else
                value = K.Value.ToString();
        }
        catch (UndefinedConstTypeArgException)
        {
            Throw(typeof(K), isUndefined: true, message: message, innerException: innerException);
        }

        Throw(typeof(K), value, message: message, innerException: innerException);
    }
}
