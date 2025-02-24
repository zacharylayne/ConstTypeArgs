namespace ConstTypeArgs.Validation;

/// <summary>
/// The <see cref="IVerificationResult"/> interface provides information about the
/// results of verifying a const type argument.
/// </summary>
/// <seealso cref="VerificationAttribute"/>
/// <seealso cref="IConstTypeArg{T}"/>
public interface IVerificationResult;

/// <summary>
/// The <see cref="IVerificationResult{T}"/> interface provides information about the
/// </summary>
/// <typeparam name="T">
/// ...
/// </typeparam>
public interface IVerificationResult<T>
    : IVerificationResult;
