namespace ConstTypeArgs.Reflection.Core;

/// <summary>
/// The <see cref="IWellKnownConstTypes"/> interface is used to indicate that a type is or implements
/// a well-known const type, such as <c>K_Bool</c>, <c>K_Byte</c>, <c>K_Char</c>, <c>K_Decimal</c>,
/// <c>K_Double</c>, <c>K_Float</c>, <c>K_Half</c>, <c>K_Int</c>, <c>K_Int128</c>, <c>K_Long</c>,
/// <c>K_SByte</c>, <c>K_Short</c>, <c>K_UInt</c>, <c>K_ULong</c>, <c>K_UShort</c>, <c>K_String</c>,
/// <c>K_Type</c>, and so on.
/// </summary>
/// <remarks>
/// The <see cref="WellKnownConstTypes"/> enumeration provides flags to identify what kind of well-known
/// const type a type may be. It also contains combinations of these flags to represent multiple well-known
/// const types grouped by function, such as <see cref="WellKnownConstTypes.Text"/>,
/// <see cref="WellKnownConstTypes.Number"/>, and <see cref="WellKnownConstTypes.Delegate"/>. Furthermore,
/// it can be used to help differentiate higher-level types, such as <see cref="WellKnownConstTypes.K_Array"/>,
/// from lower-level types that const type arguments directly implement,
/// such as <see cref="WellKnownConstTypes.K_Bool"/>.
/// </remarks>
public interface IWellKnownConstTypes
{
    /// <summary>
    /// Gets the well-known const types that this type is or implements.
    /// </summary>
    /// <value>
    /// A combination of flags that identify what kind of well-known const type a type may be.
    /// If the type is not a well-known const type, the value is <see cref="WellKnownConstTypes.None"/>.
    /// </value>
    WellKnownConstTypes WellKnownConstTypes { get; }

    /// <summary>
    /// Gets whether or not the type is a well-known const type.
    /// </summary>
    /// <value>
    /// A value of <see langword="true"/> if the type is a well-known const type; otherwise,
    /// <see langword="false"/>.
    /// </value>
    bool IsWellKnownConstType { get; }

    /// <summary>
    /// Gets whether or not the type implements a well-known const type.
    /// </summary>
    /// <value>
    /// A value of <see langword="true"/> if the type implements a well-known const type;
    /// otherwise, <see langword="false"/>.
    /// </value>
    bool ImplementsWellKnownConstType { get; }
}
