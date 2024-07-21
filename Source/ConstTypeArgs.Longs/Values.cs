namespace ConstTypeArgs.Longs;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
/// The <see cref="Default"/> readonly struct provides a const type argument equal to the
/// <see langword="default"/> of <see langword="long"/> (<c>0</c>).
/// </summary>
public readonly struct Default : K_Long<Default>
{ public static long Value => default; }

/// <summary>
/// The <see cref="MinValue"/> readonly struct provides a const type argument equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.int64.minvalue">
/// Int64.MinValue</see> (<c>-9223372036854775808</c>).
/// </summary>
public readonly struct MinValue : K_Long<MinValue>
{ public static long Value => long.MinValue; }

/// <summary>
/// The <see cref="MaxValue"/> readonly struct provides a const type argument equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.int64.maxvalue">
/// Int64.MaxValue</see> (<c>9223372036854775807</c>).
/// </summary>
public readonly struct MaxValue : K_Long<MaxValue>
{ public static long Value => long.MaxValue; }

/// <summary>
/// The <see cref="MaxDigits"/> readonly struct provides a const type argument equal to
/// the maximum number of digits in a <see langword="long"/> (<c>19</c>).
/// </summary>
public readonly struct MaxDigits : K_Long<MaxDigits>
{ public static long Value => 19; } // 9_223_372_036_854_775_807

/// <summary>
/// The <see cref="MaxHexDigits"/> readonly struct provides a const type argument equal to
/// the maximum number of hex digits in a <see langword="long"/> (<c>4</c>).
/// </summary>
public readonly struct MaxHexDigits : K_Long<MaxHexDigits>
{ public static long Value => 16; } // 0x7FFF_FFFF_FFFF_FFFF

/// <summary>
/// The <see cref="_0"/> readonly struct provides a const type argument equal to
/// <c>0</c>.
/// </summary>
public readonly struct _0 : K_Long<_0>
{ public static long Value => 0; }
