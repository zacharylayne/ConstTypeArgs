namespace ConstTypeArgs.Validation;

/// <summary>
/// The <see cref="VerificationResult"/> struct #TODO
/// </summary>
public struct VerificationResult
    : IVerificationResult;

/// <summary>
/// The <see cref="VerificationResult{T}"/> struct provides a result of the
/// </summary>
/// <typeparam name="T">
/// ...
/// </typeparam>
public struct VerificationResult<T>
   : IVerificationResult<T>;
