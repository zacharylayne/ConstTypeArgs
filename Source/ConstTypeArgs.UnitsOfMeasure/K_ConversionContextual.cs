#pragma warning disable IDE0022, IDE1006, CS1591, RCS1158
// K_ prefix is a framework convention for const type args to indicate their primary purpose
// is not to provide a contract, but to be used to "pass" values when used as generic type arguments.

namespace ConstTypeArgs.UnitsOfMeasure;

/// <summary>
/// The <see cref="K_ConversionContextual{T, TContext}"/> interface allows const type arguments that provide
/// a conversion with a context.
/// </summary>
/// <typeparam name="T">
/// The type of the value.
/// </typeparam>
/// <typeparam name="TContext">
/// The type of the context.
/// </typeparam>
public interface K_ConversionContextual<T, TContext> : K_Conversion<T>
    where T : struct, INumber<T>
    where TContext : struct
{
    /// <summary>
    /// Converts a value from this unit into the value in the common unit.
    /// </summary>
    /// <param name="value">
    /// The value to be converted.
    /// </param>
    /// <param name="context">
    /// The context for the conversion.
    /// </param>
    /// <returns>
    /// The converted value.
    /// </returns>
    static abstract T ToCommon(T value, TContext context);

    /// <summary>
    /// Converts a value from the value in the common unit to this unit.
    /// </summary>
    /// <param name="value">
    /// The value to be converted.
    /// </param>
    /// <param name="context">
    /// The context for the conversion.
    /// </param>
    /// <returns>
    /// The converted value.
    /// </returns>
    static abstract T FromCommon(T value, TContext context);
}
