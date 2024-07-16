namespace ConstTypeArgs.Int128s;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
/// The <see cref="Default"/> struct provides a const type argument equal to the
/// <see langword="default"/> of
/// <see href="https://docs.microsoft.com/dotnet/api/system.int128">
/// Int128</see> (<c>0</c>).
/// </summary>
public readonly struct Default : K_Int128<Default>

{ public static Int128 Value => default; }

/// <summary>
/// The <see cref="MinValue"/> struct provides a const type argument equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.int128.minvalue">
/// Int128.MinValue</see>.
/// </summary>
public readonly struct MinValue : K_Int128<MinValue>
{ public static Int128 Value => Int128.MinValue; }

/// <summary>
/// The <see cref="MaxValue"/> struct provides a const type argument equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.int128.maxvalue">
/// Int128.MaxValue</see>.
/// </summary>
public readonly struct MaxValue : K_Int128<MaxValue>
{ public static Int128 Value => Int128.MaxValue; }

/// <summary>
/// The <see cref="MaxDigits"/> readonly struct provides a const type argument equal to
/// the maximum number of digits in an
/// <see href="https://docs.microsoft.com/dotnet/api/system.Int128">
/// Int128</see> (<c>39</c>).
/// </summary>
public readonly struct MaxDigits : K_Int128<MaxDigits>
{ public static Int128 Value => 39; } // 170_141_183_460_469_231_731_687_303_715_884_105_727

/// <summary>
/// The <see cref="MaxHexDigits"/> readonly struct provides a const type argument equal to
/// the maximum number of hex digits in an
/// <see href="https://docs.microsoft.com/dotnet/api/system.numerics.Int128">
/// Int128</see>(<c>32</c>).
/// </summary>
public readonly struct MaxHexDigits : K_Int128<MaxHexDigits>
{ public static Int128 Value => 32; } // 0x7FFF_FFFF_FFFF_FFFF_FFFF_FFFF_FFFF_FFFF

/// <summary>
/// The <see cref="_0"/> readonly struct provides a const type argument equal to
/// <c>0</c>.
/// </summary>
public readonly struct _0 : K_Int128<_0>
{ public static Int128 Value => Int128.Zero; }
