namespace ConstTypeArgs.Core;

/// <summary>
/// The <see cref="ConstTypeException"/> class is the base ConstTypeArgs framework exception
/// for exceptions related to errors involving const types
/// <em>(const type arguments, const type interfaces, argument providers, etc.)</em>.
/// </summary>
public class ConstTypeException
    : Exception
{
    /// <summary>
    /// Initializes a new <see cref="ConstTypeException"/> instance.
    /// </summary>
    public ConstTypeException() { }

    /// <summary>
    /// Initializes a new <see cref="ConstTypeException"/> instance with the specified error message.
    /// </summary>
    /// <param name="message">
    /// The message explaining the cause of the exception.
    /// </param>
    public ConstTypeException(string message)
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
    public ConstTypeException(string message, Exception innerException)
        : base(message, innerException) { }
}
