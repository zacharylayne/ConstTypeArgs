namespace ConstTypeArgs.Ints;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
/// The <see cref="Default"/> readonly struct provides a const type argument equal to the
/// <see langword="default"/> of <see langword="int"/> (<c>0</c>).
/// </summary>
public readonly struct Default : K_Int<Default>
{ public static int Value => default; }

/// <summary>
/// The <see cref="MinValue"/> readonly struct provides a const type argument
/// equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.int32.minvalue">
/// Int32.MinValue</see> (<c>-2147483648</c>).
/// </summary>
public readonly struct MinValue : K_Int<MinValue>
{ public static int Value => int.MinValue; }

/// <summary>
/// The <see cref="MaxValue"/> readonly struct provides a const type argument
/// equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.int32.maxvalue">
/// Int32.MaxValue</see> (<c>2147483647</c>).
/// </summary>
public readonly struct MaxValue : K_Int<MaxValue>
{ public static int Value => int.MaxValue; }

/// <summary>
/// The <see cref="_0"/> readonly struct provides a const type argument equal to
/// <c>0</c>.
/// </summary>
public readonly struct _0 : K_Int<_0>
{ public static int Value => 0; }

/// <summary>
/// The <see cref="MaxDigits"/> readonly struct provides a const type argument equal to
/// the maximum number of digits in an <see langword="int"/> (<c>10</c>).
/// </summary>
public readonly struct MaxDigits : K_Int<MaxDigits>
{ public static int Value => 10; } // 2_147_483_647

/// <summary>
/// The <see cref="MaxHexDigits"/> readonly struct provides a const type argument equal to
/// the maximum number of hex digits in an <see langword="int"/> (<c>10</c>).
/// </summary>
public readonly struct MaxHexDigits : K_Int<MaxHexDigits>
{ public static int Value => 8; } // 0x7FFF_FFFF
