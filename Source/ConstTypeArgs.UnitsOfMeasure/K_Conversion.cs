#pragma warning disable IDE0022, IDE1006, CS1591, RCS1158
// K_ prefix is a framework convention for const type args to indicate their primary purpose
// is not to provide a contract, but to be used to "pass" values when used as generic type arguments.

using ConstTypeArgs.UnitsOfMeasure.Quantities;

namespace ConstTypeArgs.UnitsOfMeasure;

/// <summary>
/// The <see cref="K_Conversion{T}"/> interface allows const type arguments that provide a conversion
/// from a value in one unit to a value in another unit.
/// </summary>
/// <typeparam name="T">
/// The type of the value.
/// </typeparam>
/// <seealso cref="IQuantity{T, COMMON_UNIT}"/>
public interface K_Conversion<T> : IConstTypeArg<T>
    where T : notnull
{
    /// <summary>
    /// The <see cref="__"/> interface represents a <em>arg discard</em> which can
    /// be used to signify that the conversion is not needed or not applicable.
    /// </summary>
    /// <remarks>
    /// This can be useful when you want to indicate that a conversion is not needed,
    /// or in measures where the conversion types are mixed
    /// <em>(e.g. power with linear &amp; logarithmic conversions)</em>.
    ///  <para>
    ///  Inherit from this interface to create custom discards that can satisfy
    ///  more specific constraints.
    ///  </para>
    /// </remarks>
    interface __ : Core.__, K_Conversion<T>, IConstTypeArg<T>;
}
