using System.Text;

#pragma warning disable IDE0130 // Namespace does not match folder structure

namespace ConstTypeArgs;

/// <summary>
/// The <see cref="MisleadingConstTypeException"/> class provides an exception that is thrown when an operation is attempted
/// on a type that indicates it is a const type that it is not, causing an unrecoverable failure.
/// </summary>
/// <remarks>
/// Use the <see cref="Throw{K, K_Marked, K_IsNot}(string?, Exception?)"/>
/// and <see cref="ThrowIfMisleading{K, K_Marked, K_IsNot}(string?)"/> static methods to throw this exception.
///   <para>
///   Many const types derive from marker interfaces, such as <see cref="IConstTypeArg"/> and <see cref="K"/>,
///   that occasionally have use in activities such as type testing. However, types implementing the marker interfaces
///   do not have to implement the const type itself <em>(e.g. the type implements <see cref="IConstTypeArg"/> but
///   not <see cref="IConstTypeArg{T}"/>)</em>. In such cases where this can cause a failure that cannot be recovered from,
///   throw this exception.
///   </para>
/// </remarks>
public sealed class MisleadingConstTypeException
    : ConstTypeException
{
    /// <summary>
    /// The default description format for the exception.
    /// </summary>
    /// <seealso cref="ConstTypeException.FormatDefaultMessage"/>
    private static readonly CompositeFormat DefaultDescriptionFormat
        = CompositeFormat.Parse($$"""
            {nameof(MisleadingTypeException)}, const type {{0}} is marked as {{1}} and does not implement {{2}}
            """);

    /// <summary>
    /// Gets &amp; inits the type the const type <see cref="ConstTypeException.Type"/> is misleadingly marked as.
    /// </summary>
    /// <seealso cref="TypeNotImplemented"/>
    public required Type TypeMarked { get; init; }

    /// <summary>
    /// Gets &amp; inits the type the const type <see cref="ConstTypeException.Type"/> is
    /// misleadingly marked as implementing.
    /// </summary>
    /// <seealso cref="TypeMarked"/>
    public required Type TypeNotImplemented { get; init; }

    /// <summary>
    /// Initializes a new <see cref="MisleadingConstTypeException"/> instance.
    /// </summary>
    private MisleadingConstTypeException() { }

    /// <summary>
    /// Initializes a new <see cref="MisleadingConstTypeException"/> instance with the specified error message.
    /// </summary>
    /// <param name="message">
    /// The message explaining the cause of the exception.
    /// </param>
    private MisleadingConstTypeException(string message)
        : base(message) { }

    /// <summary>
    /// Initializes a new <see cref="MisleadingConstTypeException"/> instance with the specified error message
    /// and a reference to the inner exception that caused this one to be thrown.
    /// </summary>
    /// <param name="message">
    /// The message explaining the cause of the exception.
    /// </param>
    /// <param name="innerException">
    /// The exception that is the cause of the current exception.
    /// </param>
    private MisleadingConstTypeException(string message, Exception innerException)
        : base(message, innerException) { }

    /// <summary>
    /// Throws <see cref="MisleadingConstTypeException"/> to indicate that the const type <typeparamref name="K"/>
    /// is marked as <typeparamref name="K_Marked"/> but does not implement <typeparamref name="K_Not"/> as expected.
    /// </summary>
    /// <typeparam name="K">
    /// The const type that is the cause of the exception.
    /// </typeparam>
    /// <typeparam name="K_Marked">
    /// A marker interface that <see cref="K"/> implements.
    /// </typeparam>
    /// <typeparam name="K_Not">
    /// A const type that implements <typeparamref name="K_Marked"/>.
    /// </typeparam>
    /// <param name="message">
    /// Optional. The message explaining the cause of the exception.
    /// </param>
    /// <param name="innerException">
    /// Optional. The exception that is the cause of the current exception.
    /// </param>
    /// <remarks>
    /// This method does not and is not intended to check if <typeparamref name="K"/> implements <typeparamref name="K_Not"/>.
    /// </remarks>
    /// <exception cref="MisleadingConstTypeException"/>
    [DoesNotReturn]
    public static void Throw<K, K_Marked, K_Not>(string? message = default, Exception? innerException = default)
        where K : K_Marked
        where K_Marked : IConstTypeArg
        where K_Not : K_Marked
    {
        Type type = typeof(K);
        Type marker = typeof(K_Marked);
        Type notImplemented = typeof(K_Not);

        message ??= FormatDefaultMessage(DefaultDescriptionFormat, type.Name, marker.Name, notImplemented.Name);

        if (innerException is not null)
        {
            throw new MisleadingConstTypeException(message, innerException)
            {
                Type = type,
                TypeMarked = marker,
                TypeNotImplemented = notImplemented
            };
        }

        throw new MisleadingConstTypeException(message)
        {
            Type = type,
            TypeMarked = marker,
            TypeNotImplemented = notImplemented
        };
    }

    /// <summary>
    /// Throws <see cref="MisleadingConstTypeException"/> if the const type <typeparamref name="K"/> is marked as
    /// <typeparamref name="K_Marked"/> but does not implement <typeparamref name="K_Check"/> as expected.
    /// </summary>
    /// <typeparam name="K">
    /// The const type to check.
    /// </typeparam>
    /// <typeparam name="K_Marked">
    /// The type <typeparamref name="K"/> is marked as.
    /// </typeparam>
    /// <typeparam name="K_Check">
    /// The type to check whether or not <typeparamref name="K"/> implements.
    /// </typeparam>
    /// <param name="message">
    /// Optional. The message explaining the cause of the exception.
    /// </param>
    public static void ThrowIfMisleading<K, K_Marked, K_Check>(string? message = default)
        where K : K_Marked
        where K_Marked : IConstTypeArg
        where K_Check : K_Marked
    {
        if (typeof(K) is not K_Check)
            Throw<K, K_Marked, K_Check>(message);
    }
}
