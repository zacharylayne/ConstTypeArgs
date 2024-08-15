namespace ConstTypeArgs;

/// <summary>
/// The <see cref="NotConstTypeArgException"/> exception is thrown when an operation is attempted
/// with a type argument that is not a const type argument
/// <em>(i.e. does not inherit from <see cref="IConstTypeArg{T}"/>)</em>.
/// </summary>
public class NotConstTypeArgException
    : ConstTypeArgException
{
    /// <summary>
    /// Initializes a new <see cref="NotConstTypeArgException"/> instance.
    /// </summary>
    public NotConstTypeArgException() { }

    /// <summary>
    /// Initializes a new <see cref="NotConstTypeArgException"/> instance with the specified error message.
    /// </summary>
    /// <param name="message">
    /// The message explaining the cause of the exception.
    /// </param>
    public NotConstTypeArgException(string message)
        : base(message) { }

    /// <summary>
    /// Initializes a new <see cref="NotConstTypeArgException"/> instance with the specified error message
    /// and a reference to the inner exception that caused this one to be thrown.
    /// </summary>
    /// <param name="message">
    /// The message explaining the cause of the exception.
    /// </param>
    /// <param name="innerException">
    /// The exception that is the cause of the current exception.
    /// </param>
    public NotConstTypeArgException(string message, Exception innerException)
        : base(message, innerException) { }
}
