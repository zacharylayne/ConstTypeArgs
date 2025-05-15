namespace ConstTypeArgs.UnitsOfMeasure.Quantities;

/// <summary>
/// The <see cref="IQuantity"/> interface enables implementation of
/// the means to provide a measured quantity, such as length, area,
/// or mass.
/// </summary>
/// <seealso cref="K_Conversion{T}"/>
public interface IQuantity
{
    /// <summary>
    /// Gets the quantity's name.
    /// </summary>
    /// <value>
    /// The quantity's name.
    /// </value>
    /// <seealso cref="PluralName"/>
    /// <seealso cref="Symbol"/>
    static abstract string Name { get; }

    /// <summary>
    /// Gets the plural form of the quantity's name.
    /// </summary>
    /// <value>
    /// The plural form of the quantity's name.
    /// </value>
    /// <seealso cref="Name"/>
    /// <seealso cref="Symbol"/>
    static abstract string PluralName { get; }

    /// <summary>
    /// Gets the quantity's symbol if there is one; otherwise, an empty string.
    /// </summary>
    /// <value>
    /// The quantity's symbol if there is one; otherwise, an empty string.
    /// </value>
    /// <seealso cref="Name"/>
    /// <seealso cref="PluralName"/>
    static abstract string Symbol { get; }

    /// <summary>
    /// Gets whether or not this quantity is dimensionless or represents a physical quantity.
    /// </summary>
    /// <value>
    /// A value of <see langword="true"/> if the quantity is dimensionless;
    /// otherwise, <see langword="false"/>.
    /// </value>
    static abstract bool IsDimensionless { get; }
}

/// <summary>
/// The <see cref="IQuantity{T}"/> interface enables the implementation of
/// the means to provide a measure of a quantity of type <typeparamref name="T"/>.
/// </summary>
/// <typeparam name="T">
/// The data type of the measured quantity.
/// </typeparam>
public interface IQuantity<T> : IQuantity
    where T : struct, INumber<T>
{
    /// <summary>
    /// Gets the unit the quantity is in.
    /// </summary>
    /// <value>
    /// The unit the quantity is in.
    /// </value>
    static abstract UnitOfMeasure Unit { get; }

    /// <summary>
    /// Gets the value of the quantity.
    /// </summary>
    /// <value>
    /// The value of the quantity.
    /// </value>
    T Value { get; }
}

/// <summary>
/// The <see cref="IQuantity{T, COMMON_UNIT}"/> interface enables the implementation of
/// the means to provide a measure of a quantity of type <typeparamref name="T"/>
/// with a specific common unit <typeparamref name="COMMON_UNIT"/>
/// used to convert the quantity to and from other units
/// and to perform operations on the quantity.
/// </summary>
/// <typeparam name="T">
/// The type of the quantity's value.
/// </typeparam>
/// <typeparam name="COMMON_UNIT">
/// The const type argument representing the common unit for this quantity.
/// It should have a value equal to
/// <see cref="INumberBase{TSelf}.One">INumberBase&lt;T&gt;.One</see>.
/// </typeparam>
public interface IQuantity<T, COMMON_UNIT> : IQuantity<T>
    where T : struct, INumber<T>
    where COMMON_UNIT : struct, IUnitInfo<COMMON_UNIT>, K_Conversion<T>
{
    /// <summary>
    /// Gets the common unit for the quantity specified with <typeparamref name="COMMON_UNIT"/>.
    /// </summary>
    /// <value>
    /// The common unit for the quantity.
    /// </value>
    static abstract UnitOfMeasure CommonUnit { get; }
}
