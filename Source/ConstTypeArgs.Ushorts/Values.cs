namespace ConstTypeArgs.Ushorts;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
/// The <see cref="Default"/> readonly struct provides a const type argument equal to the
/// <see langword="default"/> of <see langword="ushort"/> (<c>0</c>).
/// </summary>
public readonly struct Default : K_Ushort<Default>
{ public static ushort Value => default; }

/// <summary>
/// The <see cref="MinValue"/> readonly struct provides a const type argument
/// equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.uint16.minvalue">
/// UInt16.MinValue</see> (<c>0</c>).
/// </summary>
public readonly struct MinValue : K_Ushort<MinValue>

{ public static ushort Value => ushort.MinValue; }

/// <summary>
/// The <see cref="MaxValue"/> readonly struct provides a const type argument
/// equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.int16.maxvalue">
/// UInt16.MaxValue</see> (<c>65535</c>).
/// </summary>
public readonly struct MaxValue : K_Ushort<MaxValue>
{ public static ushort Value => ushort.MaxValue; }

/// <summary>
/// The <see cref="MaxDigits"/> readonly struct provides a const type argument equal to
/// the maximum number of digits in a <see langword="ushort"/> (<c>5</c>).
/// </summary>
public readonly struct MaxDigits : K_Ushort<MaxDigits>
{ public static ushort Value => 5; } // 65_535

/// <summary>
/// The <see cref="MaxHexDigits"/> readonly struct provides a const type argument equal to
/// the maximum number of hex digits in a <see langword="ushort"/> (<c>4</c>).
/// </summary>
public readonly struct MaxHexDigits : K_Ushort<MaxHexDigits>
{ public static ushort Value => 4; } // 0xFFFF

/// <summary>
/// The <see cref="_0"/> readonly struct provides a const type argument equal to
/// <c>0</c>.
/// </summary>
public readonly struct _0 : K_Ushort<_0>
{ public static ushort Value => 0; }

/// <summary>
/// The <see cref="_1"/> readonly struct provides a const type argument equal to
/// <c>1</c>.
/// </summary>
public readonly struct _1 : K_Ushort<_1>
{ public static ushort Value => 1; }

/// <summary>
/// The <see cref="_2"/> readonly struct provides a const type argument equal to
/// <c>2</c>.
/// </summary>
public readonly struct _2 : K_Ushort<_2>
{ public static ushort Value => 2; }

/// <summary>
/// The <see cref="_3"/> readonly struct provides a const type argument equal to
/// <c>3</c>.
/// </summary>
public readonly struct _3 : K_Ushort<_3>
{ public static ushort Value => 3; }

/// <summary>
/// The <see cref="_4"/> readonly struct provides a const type argument equal to
/// <c>4</c>.
/// </summary>
public readonly struct _4 : K_Ushort<_4>
{ public static ushort Value => 4; }

/// <summary>
/// The <see cref="_5"/> readonly struct provides a const type argument equal to
/// <c>5</c>.
/// </summary>
public readonly struct _5 : K_Ushort<_5>
{ public static ushort Value => 5; }

/// <summary>
/// The <see cref="_6"/> readonly struct provides a const type argument equal to
/// <c>6</c>.
/// </summary>
public readonly struct _6 : K_Ushort<_6>
{ public static ushort Value => 6; }

/// <summary>
/// The <see cref="_7"/> readonly struct provides a const type argument equal to
/// <c>7</c>.
/// </summary>
public readonly struct _7 : K_Ushort<_7>
{ public static ushort Value => 7; }

/// <summary>
/// The <see cref="_8"/> readonly struct provides a const type argument equal to
/// <c>8</c>.
/// </summary>
public readonly struct _8 : K_Ushort<_8>
{ public static ushort Value => 8; }

/// <summary>
/// The <see cref="_9"/> readonly struct provides a const type argument equal to
/// <c>9</c>.
/// </summary>
public readonly struct _9 : K_Ushort<_9>
{ public static ushort Value => 9; }

/// <summary>
/// The <see cref="_10"/> readonly struct provides a const type argument equal to
/// <c>10</c>.
/// </summary>
public readonly struct _10 : K_Ushort<_10>
{ public static ushort Value => 10; }

/// <summary>
/// The <see cref="_11"/> readonly struct provides a const type argument equal to
/// <c>11</c>.
/// </summary>
public readonly struct _11 : K_Ushort<_11>
{ public static ushort Value => 11; }

/// <summary>
/// The <see cref="_12"/> readonly struct provides a const type argument equal to
/// <c>12</c>.
/// </summary>
public readonly struct _12 : K_Ushort<_12>
{ public static ushort Value => 12; }

/// <summary>
/// The <see cref="_13"/> readonly struct provides a const type argument equal to
/// <c>13</c>.
/// </summary>
public readonly struct _13 : K_Ushort<_13>
{ public static ushort Value => 13; }

/// <summary>
/// The <see cref="_14"/> readonly struct provides a const type argument equal to
/// <c>14</c>.
/// </summary>
public readonly struct _14 : K_Ushort<_14>
{ public static ushort Value => 14; }

/// <summary>
/// The <see cref="_15"/> readonly struct provides a const type argument equal to
/// <c>15</c>.
/// </summary>
public readonly struct _15 : K_Ushort<_15>
{ public static ushort Value => 15; }

/// <summary>
/// The <see cref="_16"/> readonly struct provides a const type argument equal to
/// <c>16</c> (<c>2^4</c>).
/// </summary>
public readonly struct _16 : K_Ushort<_16>
{ public static ushort Value => 16; }

/// <summary>
/// The <see cref="_25"/> readonly struct provides a const type argument equal to
/// <c>25</c>.
/// </summary>
public readonly struct _25 : K_Ushort<_25>
{ public static ushort Value => 25; }

/// <summary>
/// The <see cref="_31"/> readonly struct provides a const type argument equal to
/// <c>31</c>.
/// </summary>
public readonly struct _31 : K_Ushort<_31>
{ public static ushort Value => 31; }

/// <summary>
/// The <see cref="_32"/> readonly struct provides a const type argument equal to
/// <c>32</c> (<c>2^5</c>).
/// </summary>
public readonly struct _32 : K_Ushort<_32>
{ public static ushort Value => 32; }

/// <summary>
/// The <see cref="_50"/> readonly struct provides a const type argument equal to
/// <c>50</c>.
/// </summary>
public readonly struct _50 : K_Ushort<_50>
{ public static ushort Value => 50; }

/// <summary>
/// The <see cref="_63"/> readonly struct provides a const type argument equal to
/// <c>63</c>.
/// </summary>
public readonly struct _63 : K_Ushort<_63>
{ public static ushort Value => 63; }

/// <summary>
/// The <see cref="_64"/> readonly struct provides a const type argument equal to
/// <c>64</c> (<c>2^6</c>).
/// </summary>
public readonly struct _64 : K_Ushort<_64>
{ public static ushort Value => 64; }

/// <summary>
/// The <see cref="_100"/> readonly struct provides a const type argument equal to
/// <c>100</c>.
/// </summary>
public readonly struct _100 : K_Ushort<_100>
{ public static ushort Value => 100; }

/// <summary>
/// The <see cref="_127"/> readonly struct provides a const type argument equal to
/// <c>127</c>.
/// </summary>
public readonly struct _127 : K_Ushort<_127>
{ public static ushort Value => 127; }

/// <summary>
/// The <see cref="_128"/> readonly struct provides a const type argument equal to
/// <c>128</c> (<c>2^7</c>).
/// </summary>
public readonly struct _128 : K_Ushort<_128>
{ public static ushort Value => 128; }

/// <summary>
/// The <see cref="_200"/> readonly struct provides a const type argument equal to
/// <c>200</c>.
/// </summary>
public readonly struct _200 : K_Ushort<_200>
{ public static ushort Value => 200; }

/// <summary>
/// The <see cref="_255"/> readonly struct provides a const type argument equal to
/// <c>255</c>.
/// </summary>
public readonly struct _255 : K_Ushort<_255>
{ public static ushort Value => 255; }

/// <summary>
/// The <see cref="_256"/> readonly struct provides a const type argument equal to
/// <c>256</c> (<c>2^8</c>).
/// </summary>
public readonly struct _256 : K_Ushort<_256>
{ public static ushort Value => 256; }

/// <summary>
/// The <see cref="_511"/> readonly struct provides a const type argument equal to
/// <c>_511</c>.
/// </summary>
public readonly struct _511 : K_Ushort<_511>
{ public static ushort Value => 511; }

/// <summary>
/// The <see cref="_512"/> readonly struct provides a const type argument equal to
/// <c>512</c> (<c>2^9</c>).
/// </summary>
public readonly struct _512 : K_Ushort<_512>
{ public static ushort Value => 512; }

/// <summary>
/// The <see cref="_1023"/> readonly struct provides a const type argument equal to
/// <c>1023</c>.
/// </summary>
public readonly struct _1023 : K_Ushort<_1023>
{ public static ushort Value => 1023; }

/// <summary>
/// The <see cref="_1024"/> readonly struct provides a const type argument equal to
/// <c>1024</c> (<c>2^10</c>).
/// </summary>
public readonly struct _1024 : K_Ushort<_1024>
{ public static ushort Value => 1024; }

/// <summary>
/// The <see cref="_2047"/> readonly struct provides a const type argument equal to
/// <c>2047</c>.
/// </summary>
public readonly struct _2047 : K_Ushort<_2047>
{ public static ushort Value => 2047; }

/// <summary>
/// The <see cref="_2048"/> readonly struct provides a const type argument equal to
/// <c>2048</c> (<c>2^11</c>).
/// </summary>
public readonly struct _2048 : K_Ushort<_2048>
{ public static ushort Value => 2048; }

/// <summary>
/// The <see cref="_4095"/> readonly struct provides a const type argument equal to
/// <c>4095</c>.
/// </summary>
public readonly struct _4095 : K_Ushort<_4095>
{ public static ushort Value => 4095; }

/// <summary>
/// The <see cref="_4096"/> readonly struct provides a const type argument equal to
/// <c>4096</c> (<c>2^12</c>).
/// </summary>
public readonly struct _4096 : K_Ushort<_4096>
{ public static ushort Value => 4096; }

/// <summary>
/// The <see cref="_8191"/> readonly struct provides a const type argument equal to
/// <c>8191</c>.
/// </summary>
public readonly struct _8191 : K_Ushort<_8191>
{ public static ushort Value => 8191; }

/// <summary>
/// The <see cref="_8192"/> readonly struct provides a const type argument equal to
/// <c>8192</c> (<c>2^13</c>).
/// </summary>
public readonly struct _8192 : K_Ushort<_8192>
{ public static ushort Value => 8192; }

/// <summary>
/// The <see cref="_16384"/> readonly struct provides a const type argument equal to
/// <c>16384</c> (<c>2^14</c>).
/// </summary>
public readonly struct _16384 : K_Ushort<_16384>
{ public static ushort Value => 16_384; }

/// <summary>
/// The <see cref="_32768"/> readonly struct provides a const type argument equal to
/// <c>32768</c> (<c>2^15</c>).
/// </summary>
public readonly struct _32768 : K_Ushort<_32768>
{ public static ushort Value => 32_768; }
