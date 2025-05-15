#pragma warning disable IDE1006
// K_ prefix is a framework convention for const type args to indicate their primary purpose
// is not to provide a contract, but to be used to "pass" values when used as generic type arguments.

namespace ConstTypeArgs.UnitsOfMeasure;

/// <summary>
/// The <see cref="K_UnitKind{T, TSelf}"/> interface is the base interface for all const type arguments
/// that represent a kind of unit, and includes information about the kind of unit
/// and the data type quantities in units of this kind are in.
/// </summary>
/// <typeparam name="T">
/// The type of the value of quantities in these kinds of units.
/// </typeparam>
/// <typeparam name="TSelf">
/// The type itself.
/// </typeparam>
public interface K_UnitKind<T, TSelf> : IUnitInfo<TSelf>
    where TSelf : K_UnitKind<T, TSelf>, IConstTypeArg<T>, IUnitInfo<TSelf>;
