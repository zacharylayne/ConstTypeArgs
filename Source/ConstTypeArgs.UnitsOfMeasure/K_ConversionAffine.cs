#pragma warning disable IDE0022, IDE1006, CS1591, RCS1158
// K_ prefix is a framework convention for const type args to indicate their primary purpose
// is not to provide a contract, but to be used to "pass" values when used as generic type arguments.

namespace ConstTypeArgs.UnitsOfMeasure;

/// <summary>
/// The <see cref="K_ConversionAffine{T}"/> interface allows const type arguments that provide
/// an affine transformation with a scale factor and offsets.
/// </summary>
/// <typeparam name="T">
/// The type of the affine values.
/// </typeparam>
public interface K_ConversionAffine<T> : K_Conversion<Affine<T>>
    where T : struct, INumber<T>;

/// <summary>
/// The <see cref="K_ConversionAffine{T, TSelf}"/> interface allows const type arguments that provide
/// an affine transformation with a scale factor and offsets.
/// </summary>
/// <typeparam name="T">
/// The type of the affine values.
/// </typeparam>
/// <typeparam name="TSelf">
/// The type itself.
/// </typeparam>
public interface K_ConversionAffine<T, TSelf> : K_ConversionAffine<T>
    where T : struct, INumber<T>
    where TSelf : K_ConversionAffine<T, TSelf>
{
    /// <summary>
    /// Converts a value from this unit into the value in the common unit.
    /// </summary>
    /// <param name="value">
    /// The value to be converted.
    /// </param>
    /// <returns>
    /// The converted value.
    /// </returns>
    static virtual T ToCommonUnit(T value)
        => ((value + TSelf.Value.PreOffset) * TSelf.Value.Scale) + TSelf.Value.PostOffset;

    /// <summary>
    /// Converts a value from the value in the common unit to this unit.
    /// </summary>
    /// <param name="value">
    /// The value to be converted.
    /// </param>
    /// <returns>
    /// The converted value.
    /// </returns>
    static virtual T FromCommonUnit(T value)
        => ((value - TSelf.Value.PostOffset) / TSelf.Value.Scale) - TSelf.Value.PreOffset;
}
