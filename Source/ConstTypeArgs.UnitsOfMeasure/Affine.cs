namespace ConstTypeArgs.UnitsOfMeasure;

/// <summary>
/// The <see cref="Affine{T}"/> struct represents an affine transformation.
/// </summary>
/// <typeparam name="T">
/// The type of the affine values.
/// </typeparam>
/// <seealso cref="K_ConversionAffine{T}"/>
/// <seealso cref="K_ConversionAffine{T, TSelf}"/>
public readonly record struct Affine<T>
    where T : struct, INumber<T>
{
    /// <summary>
    /// Gets &amp; inits the scale factor.
    /// </summary>
    /// <value>
    /// The scale factor.
    /// </value>
    /// <seealso cref="PreOffset"/>
    /// <seealso cref="PostOffset"/>
    public required T Scale { get; init; }

    /// <summary>
    /// Gets &amp; inits the pre-offset.
    /// </summary>
    /// <value>
    /// The pre-offset.
    /// </value>
    /// <seealso cref="Scale"/>
    /// <seealso cref="PostOffset"/>
    public required T PreOffset { get; init; }

    /// <summary>
    /// Gets &amp; inits the post-offset.
    /// </summary>
    /// <value>
    /// The post-offset.
    /// </value>
    /// <seealso cref="Scale"/>
    /// <seealso cref="PreOffset"/>
    public required T PostOffset { get; init; }
}
