namespace ConstTypeArgs.Shorts;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
/// The <see cref="Default"/> readonly struct provides a const type argument
/// equal to <see langword="default"/> of <see langword="short"/> (<c>0</c>).
/// </summary>
public readonly struct Default : K_Short<Default>
{ public static short Value => default; }

/// <summary>
/// The <see cref="MinValue"/> readonly struct provides a const type argument
/// equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.int16.minvalue">
/// Int16.MinValue</see> (<c>-32768</c>).
/// </summary>
public readonly struct MinValue : K_Short<MinValue>

{ public static short Value => short.MinValue; }

/// <summary>
/// The <see cref="MaxValue"/> readonly struct provides a const type argument
/// equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.int16.maxvalue">
/// Int16.MaxValue</see> (<c>32767</c>).
/// </summary>
public readonly struct MaxValue : K_Short<MaxValue>
{ public static short Value => short.MaxValue; }

/// <summary>
/// The <see cref="MaxDigits"/> readonly struct provides a const type argument equal to
/// the maximum number of digits in a <see langword="short"/> (<c>5</c>).
/// </summary>
public readonly struct MaxDigits : K_Short<MaxDigits>
{ public static short Value => 5; } // 32_767

/// <summary>
/// The <see cref="MaxHexDigits"/> readonly struct provides a const type argument equal to
/// the maximum number of hex digits in a <see langword="short"/> (<c>4</c>).
/// </summary>
public readonly struct MaxHexDigits : K_Short<MaxHexDigits>
{ public static short Value => 4; } // 0x7FFF

/// <summary>
/// The <see cref="_0"/> readonly struct provides a const type argument equal to
/// <c>0</c>.
/// </summary>
public readonly struct _0 : K_Short<_0>
{ public static short Value => 0; }