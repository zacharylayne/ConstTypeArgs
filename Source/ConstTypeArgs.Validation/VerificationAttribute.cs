namespace ConstTypeArgs.Validation;

/// <summary>
/// The <see cref="VerificationAttribute"/> class provides a base attribute for
/// verification attributes that can be used to verify const type arguments.
/// </summary>
[AttributeUsage(AttributeTargets.GenericParameter,
                AllowMultiple = false, Inherited = true)]
public abstract class VerificationAttribute
    : Attribute
{
    /// <summary>
    /// Verifies the specified const argument value and returns an <see cref="IVerificationResult"/>
    /// object that provides information about the verification.
    /// </summary>
    /// <param name="argumentValue">
    /// The const type argument value to verify.
    /// </param>
    /// <param name="context">
    /// Context information for the verification.
    /// </param>
    public abstract VerificationResult Verify(object argumentValue,
        VerificationContext context);
}

/// <summary>
/// The <see cref="VerificationAttribute"/> class provides a base attribute for
/// verification attributes that can be used to verify const type arguments.
/// </summary>
public abstract class VerificationAttribute<T>
    : VerificationAttribute
{
    /// <summary>
    /// ...
    /// </summary>
    /// <param name="argumentValue">
    /// ...
    /// </param>
    /// <param name="context">
    /// ...
    /// </param>
    /// <returns>
    /// ...
    /// </returns>
    public abstract VerificationResult<T> Verify(object argumentValue,
        IVerificationContext context);
}
