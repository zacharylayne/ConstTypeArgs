using System.Text;

#pragma warning disable IDE0130 // Namespace does not match folder structure

namespace ConstTypeArgs;

/// <summary>
/// The <see cref="ConstTypeException"/> class is the basic framework exception for exceptions
/// related to errors involving const types <em>(const type arguments, const type interfaces,
/// argument providers, etc.)</em>.
/// </summary>
/// <remarks>
/// Use the <see cref="Throw(Type, string?, Exception?)"/> and <see cref="Throw{T}(string?, Exception?)"/>
/// static methods to throw this exception.
/// </remarks>
public class ConstTypeException
    : Exception
{
    /// <summary>
    /// The default description format for the exception.
    /// </summary>
    /// <seealso cref="FormatDefaultMessage"/>
    private static readonly CompositeFormat DefaultDescriptionFormat
        = CompositeFormat.Parse($"{nameof(ConstTypeException)}, const type: {{0}}");

    /// <summary>
    /// Required. Gets &amp; inits the const type that was the cause of the exception being thrown.
    /// </summary>
    public required Type Type { get; init; }

    /// <summary>
    /// Gets the name of the const type that was the cause of the exception being thrown.
    /// </summary>
    public string TypeName => Type.Name;

    /// <summary>
    /// Initializes a new <see cref="ConstTypeException"/> instance.
    /// </summary>
    protected ConstTypeException() { }

    /// <summary>
    /// Initializes a new <see cref="ConstTypeException"/> instance with the specified error message.
    /// </summary>
    /// <param name="message">
    /// The message explaining the cause of the exception.
    /// </param>
    protected ConstTypeException(string message)
        : base(message) { }

    /// <summary>
    /// Initializes a new <see cref="ConstTypeException"/> instance with the specified error message
    /// and a reference to the inner exception that caused this one to be thrown.
    /// </summary>
    /// <param name="message">
    /// The message explaining the cause of the exception.
    /// </param>
    /// <param name="innerException">
    /// The exception that is the cause of the current exception.
    /// </param>
    protected ConstTypeException(string message, Exception innerException)
        : base(message, innerException) { }

    /// <summary>
    /// Throws a new <see cref="ConstTypeException"/> with the specified parameters.
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
    /// <exception cref="ConstTypeException"/>
    /// <seealso cref="Throw{T}(string?, Exception?)"/>
    [DoesNotReturn]
    public static void Throw(Type type, string? message = default, Exception? innerException = default)
    {
        message ??= FormatDefaultMessage(DefaultDescriptionFormat, type.Name);

        if (innerException is not null)
            throw new ConstTypeException(message, innerException) { Type = type };

        throw new ConstTypeException(message) { Type = type };
    }

    /// <summary>
    /// Throws a new <see cref="ConstTypeException"/> with the specified parameters.
    /// </summary>
    /// <param name="message">
    /// Optional. The message explaining the cause of the exception.
    /// </param>
    /// <param name="innerException">
    /// Optional. The exception that is the cause of the current exception.
    /// </param>
    /// <typeparam name="T">
    /// The const type causing the exception to be thrown.
    /// </typeparam>
    /// <exception cref="ConstTypeException"/>
    /// <seealso cref="Throw(Type, string?, Exception?)"/>
    [DoesNotReturn]
    public static void Throw<T>(string? message = default, Exception? innerException = default)
    {
        Type type = typeof(T);

        message ??= FormatDefaultMessage(DefaultDescriptionFormat, type.Name);

        if (innerException is not null)
            throw new ConstTypeException(message, innerException) { Type = type };

        throw new ConstTypeException(message) { Type = type };
    }

    /// <summary>
    /// Returns a formatted message for the exception with the specified format and arguments.
    /// </summary>
    /// <param name="format">
    /// The format to use for the message.
    /// </param>
    /// <param name="args">
    /// The arguments to use for the message.
    /// </param>
    /// <returns>
    /// A formatted message for the exception.
    /// </returns>
    /// <remarks>
    /// The message is formatted using the
    /// <see href="https://learn.microsoft.com/dotnet/api/system.globalization.cultureinfo.invariantculture">
    /// System.Globalization.CultureInfo.InvariantCulture</see>
    /// to ensure that the message is formatted correctly. See the article
    /// <see href="https://learn.microsoft.com/dotnet/fundamentals/runtime-libraries/system-globalization-cultureinfo-invariantculture">
    /// System.Globalization.CultureInfo.InvariantCulture property</see> for more information about the invariant
    /// culture.
    /// </remarks>
    /// <exception cref="ArgumentNullException">
    /// Thrown <paramref name="args"/> is <see langword="null"/>.
    /// </exception>
    /// <exception cref="FormatException">
    /// Thrown <paramref name="args"/> has a length greater than or less than
    /// <see href="https://learn.microsoft.com/dotnet/api/system.text.compositeformat.minimumargumentcount">
    /// composite.MinimumArgumentCount</see>.
    /// </exception>
    protected static string FormatDefaultMessage(CompositeFormat format, params object[] args)
        => string.Format(InvariantCulture, format, args);
}
