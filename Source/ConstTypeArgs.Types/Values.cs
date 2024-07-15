namespace ConstTypeArgs.Types;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
/// The <see cref="TypeOfBool"/> readonly struct provides a const type argument
/// equal to <c><see langword="typeof"/>(<see langword="bool"/>)</c>.
/// </summary>
public readonly struct TypeOfBool : K_Type<TypeOfBool>
{ public static Type Value => typeof(bool); }

/// <summary>
/// The <see cref="TypeOfByte"/> readonly struct provides a const type argument
/// equal to <c><see langword="typeof"/>(<see langword="byte"/>)</c>.
/// </summary>
public readonly struct TypeOfByte : K_Type<TypeOfByte>
{ public static Type Value => typeof(byte); }

/// <summary>
/// The <see cref="TypeOfChar"/> readonly struct provides a const type argument
/// equal to <c><see langword="typeof"/>(<see langword="char"/>)</c>.
/// </summary>
public readonly struct TypeOfChar : K_Type<TypeOfChar>
{ public static Type Value => typeof(char); }

/// <summary>
/// The <see cref="TypeOfDecimal"/> readonly struct provides a const type argument
/// equal to <c><see langword="typeof"/>(<see langword="decimal"/>)</c>.
/// </summary>
public readonly struct TypeOfDecimal : K_Type<TypeOfDecimal>
{ public static Type Value => typeof(decimal); }

/// <summary>
/// The <see cref="TypeOfDouble"/> readonly struct provides a const type argument
/// equal to <c><see langword="typeof"/>(<see langword="double"/>)</c>.
/// </summary>
public readonly struct TypeOfDouble : K_Type<TypeOfDouble>
{ public static Type Value => typeof(double); }

/// <summary>
/// The <see cref="TypeOfFloat"/> readonly struct provides a const type argument
/// equal to <c><see langword="typeof"/>(<see langword="float"/>)</c>.
/// </summary>
public readonly struct TypeOfFloat : K_Type<TypeOfFloat>
{ public static Type Value => typeof(float); }

/// <summary>
/// The <see cref="TypeOfHalf"/> readonly struct provides a const type argument
/// equal to <c><see langword="typeof"/>(<see cref="Half"/>)</c>.
/// </summary>
public readonly struct TypeOfHalf : K_Type<TypeOfHalf>
{ public static Type Value => typeof(Half); }

/// <summary>
/// The <see cref="TypeOfInt"/> readonly struct provides a const type argument
/// equal to <c><see langword="typeof"/>(<see langword="int"/>)</c>.
/// </summary>
public readonly struct TypeOfInt : K_Type<TypeOfInt>
{ public static Type Value => typeof(int); }

/// <summary>
/// The <see cref="TypeOfInt128"/> readonly struct provides a const type argument
/// equal to <c><see langword="typeof"/>(<see cref="Int128"/>)</c>.
/// </summary>
public readonly struct TypeOfInt128 : K_Type<TypeOfInt128>
{ public static Type Value => typeof(Int128); }

/// <summary>
/// The <see cref="TypeOfLong"/> readonly struct provides a const type argument
/// equal to <c><see langword="typeof"/>(<see langword="long"/>)</c>.
/// </summary>
public readonly struct TypeOfLong : K_Type<TypeOfLong>
{ public static Type Value => typeof(long); }

/// <summary>
/// The <see cref="TypeOfNint"/> readonly struct provides a const type argument
/// equal to <c><see langword="typeof"/>(<see langword="IntPtr"/>)</c>.
/// </summary>
public readonly struct TypeOfNint : K_Type<TypeOfNint>
{ public static Type Value => typeof(IntPtr); }

/// <summary>
/// The <see cref="TypeOfNuint"/> readonly struct provides a const type argument
/// equal to <c><see langword="typeof"/>(<see langword="UIntPtr"/>)</c>.
/// </summary>
public readonly struct TypeOfNuint : K_Type<TypeOfNuint>
{ public static Type Value => typeof(UIntPtr); }

/// <summary>
/// The <see cref="TypeOfSbyte"/> readonly struct provides a const type argument
/// equal to <c><see langword="typeof"/>(<see langword="sbyte"/>)</c>.
/// </summary>
public readonly struct TypeOfSbyte : K_Type<TypeOfSbyte>
{ public static Type Value => typeof(sbyte); }

/// <summary>
/// The <see cref="TypeOfShort"/> readonly struct provides a const type argument
/// equal to <c><see langword="typeof"/>(<see langword="short"/>)</c>.
/// </summary>
public readonly struct TypeOfShort : K_Type<TypeOfShort>
{ public static Type Value => typeof(short); }

/// <summary>
/// The <see cref="TypeOfString"/> readonly struct provides a const type argument
/// equal to <c><see langword="typeof"/>(<see langword="string"/>)</c>.
/// </summary>
public readonly struct TypeOfString : K_Type<TypeOfString>
{ public static Type Value => typeof(string); }

/// <summary>
/// The <see cref="TypeOfType"/> readonly struct provides a const type argument
/// equal to <c><see langword="typeof"/>(<see langword="string"/>)</c>.
/// </summary>
public readonly struct TypeOfType : K_Type<TypeOfType>
{ public static Type Value => typeof(Type); }

/// <summary>
/// The <see cref="TypeOfUint"/> readonly struct provides a const type argument
/// equal to <c><see langword="typeof"/>(<see langword="uint"/>)</c>.
/// </summary>
public readonly struct TypeOfUint : K_Type<TypeOfUint>
{ public static Type Value => typeof(uint); }

/// <summary>
/// The <see cref="TypeOfUInt128"/> readonly struct provides a const type argument
/// equal to <c><see langword="typeof"/>(<see cref="System.UInt128"/>)</c>.
/// </summary>
public readonly struct TypeOfUInt128 : K_Type<TypeOfUInt128>
{ public static Type Value => typeof(System.UInt128); }

/// <summary>
/// The <see cref="TypeOfUlong"/> readonly struct provides a const type argument
/// equal to <c><see langword="typeof"/>(<see langword="ulong"/>)</c>.
/// </summary>
public readonly struct TypeOfUlong : K_Type<TypeOfUlong>
{ public static Type Value => typeof(ulong); }

/// <summary>
/// The <see cref="TypeOfUshort"/> readonly struct provides a const type argument
/// equal to <c><see langword="typeof"/>(<see langword="ushort"/>)</c>.
/// </summary>
public readonly struct TypeOfUshort : K_Type<TypeOfUshort>
{ public static Type Value => typeof(ushort); }
