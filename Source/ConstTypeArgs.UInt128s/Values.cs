namespace ConstTypeArgs.UInt128s;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
/// The <see cref="Default"/> readonly struct provides a const type argument equal to the
/// <see langword="default"/> of
/// <see href="https://docs.microsoft.com/dotnet/api/system.uint128">
/// UInt128</see> (<c>0</c>).
/// </summary>
public readonly struct Default : K_UInt128<Default>
{ public static UInt128 Value => default; }

/// <summary>
/// The <see cref="MinValue"/> readonly struct provides a const type argument
/// equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.uint128.minvalue">
/// UInt128.MinValue</see> (<c>0</c>).
/// </summary>
public readonly struct MinValue : K_UInt128<MinValue>

{ public static UInt128 Value => UInt128.MinValue; }

/// <summary>
/// The <see cref="MaxValue"/> readonly struct provides a const type argument
/// equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.uint128.maxvalue">
/// UInt128.MaxValue</see> (<c>340282366920938463463374607431768211455</c>).
/// </summary>
public readonly struct MaxValue : K_UInt128<MaxValue>

{ public static UInt128 Value => UInt128.MaxValue; }

/// <summary>
/// The <see cref="MaxDigits"/> readonly struct provides a const type argument equal to
/// the maximum number of digits in an
/// <see href="https://docs.microsoft.com/dotnet/api/system.uint128">
/// UInt128</see> (<c>39</c>).
/// </summary>
public readonly struct MaxDigits : K_UInt128<MaxDigits>
{ public static UInt128 Value => 39; } // 340_282_366_920_938_463_463_374_607_431_768_211_455

/// <summary>
/// The <see cref="MaxHexDigits"/> readonly struct provides a const type argument equal to
/// the maximum number of hex digits in an
/// <see href="https://docs.microsoft.com/dotnet/api/system.uint128">
/// UInt128</see>(<c>32</c>).
/// </summary>
public readonly struct MaxHexDigits : K_UInt128<MaxHexDigits>
{ public static UInt128 Value => 32; } // 0xFFFF_FFFF_FFFF_FFFF_FFFF_FFFF_FFFF_FFFF

/// <summary>
/// The <see cref="_0"/> readonly struct provides a const type argument equal to
/// <c>0</c>.
/// </summary>
public readonly struct _0 : K_UInt128<_0>

{ public static UInt128 Value => UInt128.Zero; }

/// <summary>
/// The <see cref="_1"/> readonly struct provides a const type argument equal to
/// <c>1</c>.
/// </summary>
public readonly struct _1 : K_UInt128<_1>
{ public static UInt128 Value => UInt128.One; }

/// <summary>
/// The <see cref="_2"/> readonly struct provides a const type argument equal to
/// <c>2</c>.
/// </summary>
public readonly struct _2 : K_UInt128<_2>
{ public static UInt128 Value => 2; }

/// <summary>
/// The <see cref="_3"/> readonly struct provides a const type argument equal to
/// <c>3</c>.
/// </summary>
public readonly struct _3 : K_UInt128<_3>
{ public static UInt128 Value => 3; }

/// <summary>
/// The <see cref="_4"/> readonly struct provides a const type argument equal to
/// <c>4</c>.
/// </summary>
public readonly struct _4 : K_UInt128<_4>
{ public static UInt128 Value => 4; }

/// <summary>
/// The <see cref="_5"/> readonly struct provides a const type argument equal to
/// <c>5</c>.
/// </summary>
public readonly struct _5 : K_UInt128<_5>
{ public static UInt128 Value => 5; }

/// <summary>
/// The <see cref="_6"/> readonly struct provides a const type argument equal to
/// <c>6</c>.
/// </summary>
public readonly struct _6 : K_UInt128<_6>
{ public static UInt128 Value => 6; }

/// <summary>
/// The <see cref="_7"/> readonly struct provides a const type argument equal to
/// <c>7</c>.
/// </summary>
public readonly struct _7 : K_UInt128<_7>
{ public static UInt128 Value => 7; }

/// <summary>
/// The <see cref="_8"/> readonly struct provides a const type argument equal to
/// <c>8</c>.
/// </summary>
public readonly struct _8 : K_UInt128<_8>
{ public static UInt128 Value => 8; }

/// <summary>
/// The <see cref="_9"/> readonly struct provides a const type argument equal to
/// <c>9</c>.
/// </summary>
public readonly struct _9 : K_UInt128<_9>
{ public static UInt128 Value => 9; }

/// <summary>
/// The <see cref="_10"/> readonly struct provides a const type argument equal to
/// <c>10</c>.
/// </summary>
public readonly struct _10 : K_UInt128<_10>
{ public static UInt128 Value => 10; }

/// <summary>
/// The <see cref="_11"/> readonly struct provides a const type argument equal to
/// <c>11</c>.
/// </summary>
public readonly struct _11 : K_UInt128<_11>
{ public static UInt128 Value => 11; }

/// <summary>
/// The <see cref="_12"/> readonly struct provides a const type argument equal to
/// <c>12</c>.
/// </summary>
public readonly struct _12 : K_UInt128<_12>
{ public static UInt128 Value => 12; }

/// <summary>
/// The <see cref="_13"/> readonly struct provides a const type argument equal to
/// <c>13</c>.
/// </summary>
public readonly struct _13 : K_UInt128<_13>
{ public static UInt128 Value => 13; }

/// <summary>
/// The <see cref="_14"/> readonly struct provides a const type argument equal to
/// <c>14</c>.
/// </summary>
public readonly struct _14 : K_UInt128<_14>
{ public static UInt128 Value => 14; }

/// <summary>
/// The <see cref="_15"/> readonly struct provides a const type argument equal to
/// <c>15</c>.
/// </summary>
public readonly struct _15 : K_UInt128<_15>
{ public static UInt128 Value => 15; }

/// <summary>
/// The <see cref="_16"/> readonly struct provides a const type argument equal to
/// <c>16</c>.
/// </summary>
public readonly struct _16 : K_UInt128<_16>
{ public static UInt128 Value => 16; }
