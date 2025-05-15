#pragma warning disable IDE0022, IDE1006, CS1591, RCS1158
// K_ prefix is a framework convention for const type args to indicate their primary purpose
// is not to provide a contract, but to be used to "pass" values when used as generic type arguments.

namespace ConstTypeArgs.UnitsOfMeasure;

/// <summary>
/// The <see cref="K_ConversionFactor{T}"/> interface allows const type arguments that provide
/// a conversion factor to convert a value in one unit to the same value in another unit.
/// </summary>
/// <typeparam name="T">
/// The type of the value.
/// </typeparam>
public interface K_ConversionFactor<T> : K_Conversion<T>
    where T : struct, INumber<T>;

/// <summary>
/// The <see cref="K_ConversionFactor{T, TSelf}"/> interface allows const type arguments that provide
/// a conversion factor to convert a value in one unit to the same value in another unit.
/// </summary>
/// <typeparam name="T">
/// The type of the value.
/// </typeparam>
/// <typeparam name="TSelf">
/// The type itself.
/// </typeparam>
public interface K_ConversionFactor<T, TSelf> : K_ConversionFactor<T>
    where T : struct, INumber<T>
    where TSelf : K_ConversionFactor<T, TSelf>
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
    /// <seealso cref="FromCommonUnit(T)"/>
    static virtual T ToCommonUnit(T value) => value * TSelf.Value;

    /// <summary>
    /// Converts a value from the value in the common unit to this unit.
    /// </summary>
    /// <param name="value">
    /// The value to be converted.
    /// </param>
    /// <returns>
    /// The converted value.
    /// </returns>
    /// <seealso cref="ToCommonUnit(T)"/>
    static virtual T FromCommonUnit(T value) => value / TSelf.Value;
}
