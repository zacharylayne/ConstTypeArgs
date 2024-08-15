using ConstTypeArgs.Core;

namespace ConstTypeArgs;

/// <summary>
/// The <see cref="ConstTypeArgException"/> exception is thrown when an operation is attempted
/// on a const type argument and an error occurs.
/// </summary>
public class ConstTypeArgException
    : ConstTypeException
{
    /// <summary>
    /// Initializes a new <see cref="ConstTypeArgException"/> instance.
    /// </summary>
    public ConstTypeArgException() { }

    /// <summary>
    /// Initializes a new <see cref="ConstTypeArgException"/> instance with the specified error message.
    /// </summary>
    /// <param name="message">
    /// The message explaining the cause of the exception.
    /// </param>
    public ConstTypeArgException(string message)
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
    public ConstTypeArgException(string message, Exception innerException)
        : base(message, innerException) { }
}
