namespace ConstTypeArgs.UnitsOfMeasure;

/// <summary>
/// The <see cref="ConversionFuncPair{T}"/> struct represents a pair of conversion functions.
/// </summary>
/// <typeparam name="T">
/// The type of the input &amp; output values.
/// </typeparam>
public readonly record struct ConversionFuncPair<T>
    where T : struct, INumber<T>
{
    /// <summary>
    /// Gets &amp; inits the conversion function.
    /// </summary>
    /// <value>
    /// The conversion function.
    /// </value>
    public required Func<T, T> ToFunc { get; init; }

    /// <summary>
    /// Gets &amp; inits the inverse conversion function.
    /// </summary>
    /// <value>
    /// The inverse conversion function.
    /// </value>
    public required Func<T, T> FromFunc { get; init; }
}
