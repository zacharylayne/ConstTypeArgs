#pragma warning disable IDE0022, IDE1006, CS1591, RCS1158
// K_ prefix is a framework convention for const type args to indicate their primary purpose
// is not to provide a contract, but to be used to "pass" values when used as generic type arguments.

namespace ConstTypeArgs.UnitsOfMeasure;

/// <summary>
/// The <see cref="K_ConversionPolynomial{T}"/> interface allows const type arguments that provide
/// a polynomial conversion.
/// </summary>
/// <typeparam name="T">
/// The type of the value.
/// </typeparam>
public interface K_ConversionPolynomial<T> : K_Conversion<T>
    where T : struct, INumber<T>, IPowerFunctions<T>, IExponentialFunctions<T>, ILogarithmicFunctions<T>;

/// <summary>
/// The <see cref="K_ConversionPolynomial{T, TSelf}"/> interface allows const type arguments that provide
/// a polynomial conversion.
/// </summary>
/// <typeparam name="T">
/// The type of the value.
/// </typeparam>
/// <typeparam name="TSelf">
/// The type itself.
/// </typeparam>
public interface K_ConversionPolynomial<T, TSelf> : K_ConversionPolynomial<T>
    where T : struct, INumber<T>, IPowerFunctions<T>, IExponentialFunctions<T>, ILogarithmicFunctions<T>
    where TSelf : K_ConversionPolynomial<T, TSelf>
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
        => T.CreateChecked(10) * T.Pow(T.CreateChecked(10), value / TSelf.Value);

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
        => TSelf.Value * T.Log10(value / T.CreateChecked(10));
}
