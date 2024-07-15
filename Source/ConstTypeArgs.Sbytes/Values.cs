namespace ConstTypeArgs.Sbytes;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
/// The <see cref="Default"/> readonly struct provides a const type argument equal to the
/// <see langword="default"/> of <see langword="sbyte"/>
/// (<c>0</c>).
/// </summary>
public readonly struct Default : K_Sbyte<Default>
{ public static sbyte Value => default; }

/// <summary>
/// The <see cref="MinValue"/> readonly struct provides a const type argument
/// equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.sbyte.minvalue">
/// SByte.MinValue</see> (<c>-128</c>).
/// </summary>
public readonly struct MinValue : K_Sbyte<MinValue>
{ public static sbyte Value => sbyte.MinValue; }

/// <summary>
/// The <see cref="MaxValue"/> readonly struct provides a const type argument
/// equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.sbyte.maxvalue">
/// SByte.MaxValue</see> (<c>127</c>).
/// </summary>
public readonly struct MaxValue : K_Sbyte<MaxValue>
{ public static sbyte Value => sbyte.MaxValue; }

/// <summary>
/// The <see cref="MaxDigits"/> readonly struct provides a const type argument equal to
/// the maximum number of digits in a <see langword="sbyte"/> (<c>3</c>).
/// </summary>
public readonly struct MaxDigits : K_Sbyte<MaxDigits>
{ public static sbyte Value => 3; } // 127

/// <summary>
/// The <see cref="MaxHexDigits"/> readonly struct provides a const type argument equal to
/// the maximum number of hex digits in a <see langword="sbyte"/> (<c>2</c>).
/// </summary>
public readonly struct MaxHexDigits : K_Sbyte<MaxDigits>
{ public static sbyte Value => 2; } // 0x7F

/// <summary>
/// The <see cref="_0"/> readonly struct provides a const type argument equal to
/// <c>0</c>.
/// </summary>
public readonly struct _0 : K_Sbyte<_0>
{ public static sbyte Value => 0; }
