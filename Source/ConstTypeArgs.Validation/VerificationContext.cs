namespace ConstTypeArgs.Validation;

/// <summary>
/// The <see cref="VerificationContext"/> struct #TODO
/// </summary>
public readonly struct VerificationContext
    : IVerificationContext
{
    /// <inheritdoc/>
    public readonly string DeclaringTypeName => throw new NotImplementedException();

    /// <inheritdoc/>
    public readonly Type DeclaringType => throw new NotImplementedException();

    /// <inheritdoc/>
    public readonly string GenericParameterName => throw new NotImplementedException();

    /// <inheritdoc/>
    public readonly Type GenericParameterType => throw new NotImplementedException();

    /// <inheritdoc/>
    public readonly object? GetArgumentValue()
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// The <see cref="VerificationContext{T}"/> struct #TODO
/// </summary>
/// <typeparam name="T">
/// ...
/// </typeparam>
public readonly struct VerificationContext<T>
    : IVerificationContext<T>
{
    /// <inheritdoc/>
    public readonly T? ArgumentValue => throw new NotImplementedException();

    /// <inheritdoc/>
    public readonly string DeclaringTypeName => throw new NotImplementedException();

    /// <inheritdoc/>
    public readonly Type DeclaringType => throw new NotImplementedException();

    /// <inheritdoc/>
    public readonly string GenericParameterName => throw new NotImplementedException();

    /// <inheritdoc/>
    public readonly Type GenericParameterType => throw new NotImplementedException();

    /// <inheritdoc/>
    public readonly object? GetArgumentValue()
    {
        throw new NotImplementedException();
    }
}
