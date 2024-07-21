namespace ConstTypeArgs.Bytes;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
/// The <see cref="Default"/> readonly struct provides a const type argument equal to
/// <see langword="default"/> of <see langword="byte"/> (<c>0</c>).
/// </summary>
public readonly struct Default : K_Byte<Default>
{ public static byte Value => default; }

/// <summary>
/// The <see cref="MinValue"/> readonly struct provides a const type argument equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.byte.minvalue">
/// Byte.MinValue</see> (<c>0</c>).
/// </summary>
public readonly struct MinValue : K_Byte<MinValue>
{ public static byte Value => byte.MinValue; }

/// <summary>
/// The <see cref="MaxValue"/> readonly struct provides a const type argument equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.byte.maxvalue">
/// Byte.MaxValue</see> (<c>255</c>).
/// </summary>
public readonly struct MaxValue : K_Byte<MaxValue>
{ public static byte Value => byte.MaxValue; }

/// <summary>
/// The <see cref="MaxDigits"/> readonly struct provides a const type argument equal to
/// the maximum number of digits in a <see langword="byte"/> (<c>3</c>).
/// </summary>
public readonly struct MaxDigits : K_Byte<MaxDigits>
{ public static byte Value => 3; } // 255

/// <summary>
/// The <see cref="MaxHexDigits"/> readonly struct provides a const type argument equal to
/// the maximum number of hex digits in a <see langword="byte"/> (<c>2</c>).
/// </summary>
public readonly struct MaxHexDigits : K_Byte<MaxDigits>
{ public static byte Value => 2; } // 0xFF

#region 0 -  10

/// <summary>
/// The <see cref="_0"/> readonly struct provides a const type argument equal to
/// <c>0</c>.
/// </summary>
public readonly struct _0 : K_Byte<_0>
{ public static byte Value => 0; }

/// <summary>
/// The <see cref="_1"/> readonly struct provides a const type argument equal to
/// <c>1</c>.
/// </summary>
public readonly struct _1 : K_Byte<_1>
{ public static byte Value => 1; }

/// <summary>
/// The <see cref="_2"/> readonly struct provides a const type argument equal to
/// <c>2</c>.
/// </summary>
public readonly struct _2 : K_Byte<_2>
{ public static byte Value => 2; }

/// <summary>
/// The <see cref="_3"/> readonly struct provides a const type argument equal to
/// <c>3</c>.
/// </summary>
public readonly struct _3 : K_Byte<_3>
{ public static byte Value => 3; }

/// <summary>
/// The <see cref="_4"/> readonly struct provides a const type argument equal to
/// <c>4</c>.
/// </summary>
public readonly struct _4 : K_Byte<_4>
{ public static byte Value => 4; }

/// <summary>
/// The <see cref="_5"/> readonly struct provides a const type argument equal to
/// <c>5</c>.
/// </summary>
public readonly struct _5 : K_Byte<_5>
{ public static byte Value => 5; }

/// <summary>
/// The <see cref="_6"/> readonly struct provides a const type argument equal to
/// <c>6</c>.
/// </summary>
public readonly struct _6 : K_Byte<_6>
{ public static byte Value => 6; }

/// <summary>
/// The <see cref="_7"/> readonly struct provides a const type argument equal to
/// <c>7</c>.
/// </summary>
public readonly struct _7 : K_Byte<_7>
{ public static byte Value => 7; }

/// <summary>
/// The <see cref="_8"/> readonly struct provides a const type argument equal to
/// <c>8</c>.
/// </summary>
public readonly struct _8 : K_Byte<_8>
{ public static byte Value => 8; }

/// <summary>
/// The <see cref="_9"/> readonly struct provides a const type argument equal to
/// <c>9</c>.
/// </summary>
public readonly struct _9 : K_Byte<_9>
{ public static byte Value => 9; }

/// <summary>
/// The <see cref="_10"/> readonly struct provides a const type argument equal to
/// <c>10</c>.
/// </summary>
public readonly struct _10 : K_Byte<_10>
{ public static byte Value => 10; }

#endregion 0 -  10

/// <summary>
/// The <see cref="_15"/> readonly struct provides a const type argument equal to
/// <c>15</c>.
/// </summary>
public readonly struct _15 : K_Byte<_15>
{ public static byte Value => 15; }

/// <summary>
/// The <see cref="_16"/> readonly struct provides a const type argument equal to
/// <c>16</c> (<c>2^4</c>).
/// </summary>
public readonly struct _16 : K_Byte<_16>
{ public static byte Value => 16; }

/// <summary>
/// The <see cref="_25"/> readonly struct provides a const type argument equal to
/// <c>25</c>.
/// </summary>
public readonly struct _25 : K_Byte<_25>
{ public static byte Value => 25; }

/// <summary>
/// The <see cref="_31"/> readonly struct provides a const type argument equal to
/// <c>31</c>.
/// </summary>
public readonly struct _31 : K_Byte<_31>
{ public static byte Value => 31; }

/// <summary>
/// The <see cref="_32"/> readonly struct provides a const type argument equal to
/// <c>32</c> (<c>2^5</c>).
/// </summary>
public readonly struct _32 : K_Byte<_32>
{ public static byte Value => 32; }

/// <summary>
/// The <see cref="_50"/> readonly struct provides a const type argument equal to
/// <c>50</c>.
/// </summary>
public readonly struct _50 : K_Byte<_50>
{ public static byte Value => 50; }

/// <summary>
/// The <see cref="_63"/> readonly struct provides a const type argument equal to
/// <c>63</c>.
/// </summary>
public readonly struct _63 : K_Byte<_63>
{ public static byte Value => 63; }

/// <summary>
/// The <see cref="_64"/> readonly struct provides a const type argument equal to
/// <c>64</c> (<c>2^6</c>).
/// </summary>
public readonly struct _64 : K_Byte<_64>
{ public static byte Value => 64; }

/// <summary>
/// The <see cref="_100"/> readonly struct provides a const type argument equal to
/// <c>100</c>.
/// </summary>
public readonly struct _100 : K_Byte<_100>
{ public static byte Value => 100; }

/// <summary>
/// The <see cref="_127"/> readonly struct provides a const type argument equal to
/// <c>127</c>.
/// </summary>
public readonly struct _127 : K_Byte<_127>
{ public static byte Value => 127; }

/// <summary>
/// The <see cref="_128"/> readonly struct provides a const type argument equal to
/// <c>128</c> (<c>2^7</c>).
/// </summary>
public readonly struct _128 : K_Byte<_128>
{ public static byte Value => 128; }

/// <summary>
/// The <see cref="_200"/> readonly struct provides a const type argument equal to
/// <c>200</c>.
/// </summary>
public readonly struct _200 : K_Byte<_200>
{ public static byte Value => 200; }

/// <summary>
/// The <see cref="_255"/> readonly struct provides a const type argument equal to
/// <c>255</c> (<c>2^8 - 1</c>).
/// </summary>
public readonly struct _255 : K_Byte<_255>
{ public static byte Value => 255; }
