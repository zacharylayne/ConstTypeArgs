using System.Text;

namespace ConstTypeArgs;

/// <summary>
/// The <see cref="UndefinedConstTypeArgException"/> class is thrown when an operation is expecting
/// a const type argument to have a value, but the value is undefined, causing an unrecoverable failure.
/// </summary>
/// <remarks>
/// Use the <see cref="Throw(Type, string?, Exception?)"/>, <see cref="Throw{K}(string?, Exception?)"/>,
/// and <see cref="ThrowIfNoValue{T, K}(string?)"/> static methods to throw this exception.
/// </remarks>
public sealed class UndefinedConstTypeArgException
    : ConstTypeException
{
    /// <summary>
    /// The default description format for the exception.
    /// </summary>
    /// <seealso cref="ConstTypeException.FormatDefaultMessage(CompositeFormat, object[])"/>
    private static readonly CompositeFormat DefaultDescriptionFormat
        = CompositeFormat.Parse($$"""
          {nameof(NoConstTypeArgValueException)}, const arg {{0}} was expected to have a value
          but is valueless
          """);

    /// <summary>
    /// Initializes a new <see cref="UndefinedConstTypeArgException"/> instance.
    /// </summary>
    private UndefinedConstTypeArgException() { }

    /// <summary>
    /// Initializes a new <see cref="UndefinedConstTypeArgException"/> instance with the specified error message.
    /// </summary>
    /// <param name="message">
    /// The message explaining the cause of the exception.
    /// </param>
    private UndefinedConstTypeArgException(string message)
        : base(message) { }

    /// <summary>
    /// Initializes a new <see cref="UndefinedConstTypeArgException"/> instance with the specified error message
    /// and a reference to the inner exception that caused this one to be thrown.
    /// </summary>
    /// <param name="message">
    /// The message explaining the cause of the exception.
    /// </param>
    /// <param name="innerException">
    /// The exception that is the cause of the current exception.
    /// </param>
    private UndefinedConstTypeArgException(string message, Exception innerException)
        : base(message, innerException) { }

    /// <summary>
    /// Throws a new <see cref="UndefinedConstTypeArgException"/> with the specified parameters.
    /// </summary>
    /// <param name="type">
    /// The type causing the exception to be thrown.
    /// </param>
    /// <param name="message">
    /// Optional. The message explaining the cause of the exception.
    /// </param>
    /// <param name="innerException">
    /// Optional. The exception that is the cause of the current exception.
    /// </param>
    /// <remarks>
    /// This method does not and is not intended to check if <paramref name="type"/> is a const type itself.
    /// </remarks>
    /// <exception cref="UndefinedConstTypeArgException"/>
    /// <seealso cref="Throw{K}(string?, Exception?)"/>
    /// <seealso cref="ThrowIfNoValue{T, K}(string?)"/>
    [DoesNotReturn]
    public static new void Throw(Type type, string? message = default, Exception? innerException = default)
    {
        message ??= FormatDefaultMessage(DefaultDescriptionFormat, type.Name);

        if (innerException is not null)
            throw new UndefinedConstTypeArgException(message, innerException) { Type = type };

        throw new UndefinedConstTypeArgException(message) { Type = type };
    }

    /// <summary>
    /// Throws a new <see cref="UndefinedConstTypeArgException"/> with the specified parameters.
    /// </summary>
    /// <param name="message">
    /// Optional. The message explaining the cause of the exception.
    /// </param>
    /// <param name="innerException">
    /// Optional. The exception that is the cause of the current exception.
    /// </param>
    /// <typeparam name="K">
    /// The const type causing the exception to be thrown.
    /// </typeparam>
    /// <exception cref="UndefinedConstTypeArgException"/>
    /// <seealso cref="Throw(Type, string?, Exception?)"/>
    /// <seealso cref="ThrowIfNoValue{T, K}(string?)"/>
    [DoesNotReturn]
    public static new void Throw<K>(string? message = default, Exception? innerException = default)
        where K : IConstTypeArg
    {
        Type type = typeof(K);

        message ??= FormatDefaultMessage(DefaultDescriptionFormat, type.Name);

        if (innerException is not null)
            throw new UndefinedConstTypeArgException(message, innerException) { Type = type };

        throw new UndefinedConstTypeArgException(message) { Type = type };
    }

    /// <summary>
    /// Throws a new <see cref="UndefinedConstTypeArgException"/> with the specified message if either
    /// the const type argument <typeparamref name="K"/> has no value or <typeparamref name="K"/>
    /// is a type of <em>discard</em> const type argument <em>(i.e. a const type argument implementing
    /// <see cref="Core.__"/> to indicate it has no value)</em>.
    /// </summary>
    /// <typeparam name="T">
    /// The type of the value of the const type argument <typeparamref name="K"/>.
    /// </typeparam>
    /// <typeparam name="K">
    /// The const type argument.
    /// </typeparam>
    /// <param name="message">
    /// Optional. The message explaining the cause of the exception.
    /// </param>
    /// <exception cref="UndefinedConstTypeArgException"/>
    /// <seealso cref="Throw(Type, string?, Exception?)"/>
    /// <seealso cref="Throw{K}(string?, Exception?)"/>
    public static void ThrowIfNoValue<T, K>(string? message = default)
        where K : IConstTypeArg<T>
    {
        if (typeof(K) is Core.__)
            Throw<K>(message);

        try
        {
            T? _ = K.Value;
        }
        catch (UndefinedConstTypeArgException e)
        {
            Throw<K>(message, e);
        }
    }
}
