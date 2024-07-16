namespace ConstTypeArgs.Ulongs;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
/// The <see cref="Default"/> readonly struct provides a const type argument equal to the
/// <see langword="default"/> of <see langword="ulong"/> (<c>0</c>).
/// </summary>
public readonly struct Default : K_Ulong<Default>
{ public static ulong Value => default; }

/// <summary>
/// The <see cref="MinValue"/> readonly struct provides a const type argument equal to
/// <see href="https://learn.microsoft.com/dotnet/api/system.uint64.minvalue">
/// UInt64.MinValue</see> (<c>0</c>).
/// </summary>
public readonly struct MinValue : K_Ulong<MinValue>
{ public static ulong Value => ulong.MinValue; }

/// <summary>
/// The <see cref="MaxValue"/> readonly struct provides a const type argument equal to
/// <see href="https://learn.microsoft.com/dotnet/api/system.uint64.maxvalue">
/// UInt64.MaxValue</see>(<c>18446744073709551615</c>).
/// </summary>
public readonly struct MaxValue : K_Ulong<MaxValue>
{ public static ulong Value => ulong.MaxValue; }

/// <summary>
/// The <see cref="MaxDigits"/> readonly struct provides a const type argument equal to
/// the maximum number of digits in a <see langword="ulong"/> (<c>20</c>).
/// </summary>
public readonly struct MaxDigits : K_Ulong<MaxDigits>
{ public static ulong Value => 20; } // 18_446_744_073_709_551_615

/// <summary>
/// The <see cref="MaxHexDigits"/> readonly struct provides a const type argument equal to
/// the maximum number of hex digits in a <see langword="ulong"/> (<c>16</c>).
/// </summary>
public readonly struct MaxHexDigits : K_Ulong<MaxHexDigits>
{ public static ulong Value => 16; }  // 0xFFFF_FFFF_FFFF_FFFF

/// <summary>
/// The <see cref="_0"/> readonly struct provides a const type argument equal to
/// <c>0</c>.
/// </summary>
public readonly struct _0 : K_Ulong<_0>
{ public static ulong Value => 0; }

/// <summary>
/// The <see cref="_1"/> readonly struct provides a const type argument equal to
/// <c>1</c>.
/// </summary>
public readonly struct _1 : K_Ulong<_1>
{ public static ulong Value => 1; }

/// <summary>
/// The <see cref="_2"/> readonly struct provides a const type argument equal to
/// <c>2</c>.
/// </summary>
public readonly struct _2 : K_Ulong<_2>
{ public static ulong Value => 2; }

/// <summary>
/// The <see cref="_3"/> readonly struct provides a const type argument equal to
/// <c>3</c>.
/// </summary>
public readonly struct _3 : K_Ulong<_3>
{ public static ulong Value => 3; }

/// <summary>
/// The <see cref="_4"/> readonly struct provides a const type argument equal to
/// <c>4</c>.
/// </summary>
public readonly struct _4 : K_Ulong<_4>
{ public static ulong Value => 4; }

/// <summary>
/// The <see cref="_5"/> readonly struct provides a const type argument equal to
/// <c>5</c>.
/// </summary>
public readonly struct _5 : K_Ulong<_5>
{ public static ulong Value => 5; }

/// <summary>
/// The <see cref="_6"/> readonly struct provides a const type argument equal to
/// <c>6</c>.
/// </summary>
public readonly struct _6 : K_Ulong<_6>
{ public static ulong Value => 6; }

/// <summary>
/// The <see cref="_7"/> readonly struct provides a const type argument equal to
/// <c>7</c>.
/// </summary>
public readonly struct _7 : K_Ulong<_7>
{ public static ulong Value => 7; }

/// <summary>
/// The <see cref="_8"/> readonly struct provides a const type argument equal to
/// <c>8</c>.
/// </summary>
public readonly struct _8 : K_Ulong<_8>
{ public static ulong Value => 8; }

/// <summary>
/// The <see cref="_9"/> readonly struct provides a const type argument equal to
/// <c>9</c>.
/// </summary>
public readonly struct _9 : K_Ulong<_9>
{ public static ulong Value => 9; }

/// <summary>
/// The <see cref="_10"/> readonly struct provides a const type argument equal to
/// <c>10</c>.
/// </summary>
public readonly struct _10 : K_Ulong<_10>
{ public static ulong Value => 10; }

/// <summary>
/// The <see cref="_11"/> readonly struct provides a const type argument equal to
/// <c>11</c>.
/// </summary>
public readonly struct _11 : K_Ulong<_11>
{ public static ulong Value => 11; }

/// <summary>
/// The <see cref="_12"/> readonly struct provides a const type argument equal to
/// <c>12</c>.
/// </summary>
public readonly struct _12 : K_Ulong<_12>
{ public static ulong Value => 12; }

/// <summary>
/// The <see cref="_13"/> readonly struct provides a const type argument equal to
/// <c>13</c>.
/// </summary>
public readonly struct _13 : K_Ulong<_13>
{ public static ulong Value => 13; }

/// <summary>
/// The <see cref="_14"/> readonly struct provides a const type argument equal to
/// <c>14</c>.
/// </summary>
public readonly struct _14 : K_Ulong<_14>
{ public static ulong Value => 14; }

/// <summary>
/// The <see cref="_15"/> readonly struct provides a const type argument equal to
/// <c>15</c>.
/// </summary>
public readonly struct _15 : K_Ulong<_15>
{ public static ulong Value => 15; }

/// <summary>
/// The <see cref="_16"/> readonly struct provides a const type argument equal to
/// <c>16</c> (<c>2^4</c>).
/// </summary>
public readonly struct _16 : K_Ulong<_16>
{ public static ulong Value => 16; }

/// <summary>
/// The <see cref="_25"/> readonly struct provides a const type argument equal to
/// <c>25</c>.
/// </summary>
public readonly struct _25 : K_Ulong<_25>
{ public static ulong Value => 25; }

/// <summary>
/// The <see cref="_31"/> readonly struct provides a const type argument equal to
/// <c>31</c>.
/// </summary>
public readonly struct _31 : K_Ulong<_31>
{ public static ulong Value => 31; }

/// <summary>
/// The <see cref="_32"/> readonly struct provides a const type argument equal to
/// <c>32</c> (<c>2^5</c>).
/// </summary>
public readonly struct _32 : K_Ulong<_32>
{ public static ulong Value => 32; }

/// <summary>
/// The <see cref="_50"/> readonly struct provides a const type argument equal to
/// <c>50</c>.
/// </summary>
public readonly struct _50 : K_Ulong<_50>
{ public static ulong Value => 50; }

/// <summary>
/// The <see cref="_63"/> readonly struct provides a const type argument equal to
/// <c>63</c>.
/// </summary>
public readonly struct _63 : K_Ulong<_63>
{ public static ulong Value => 63; }

/// <summary>
/// The <see cref="_64"/> readonly struct provides a const type argument equal to
/// <c>64</c> (<c>2^6</c>).
/// </summary>
public readonly struct _64 : K_Ulong<_64>
{ public static ulong Value => 64; }

/// <summary>
/// The <see cref="_100"/> readonly struct provides a const type argument equal to
/// <c>100</c>.
/// </summary>
public readonly struct _100 : K_Ulong<_100>
{ public static ulong Value => 100; }

/// <summary>
/// The <see cref="_127"/> readonly struct provides a const type argument equal to
/// <c>127</c>.
/// </summary>
public readonly struct _127 : K_Ulong<_127>
{ public static ulong Value => 127; }

/// <summary>
/// The <see cref="_128"/> readonly struct provides a const type argument equal to
/// <c>128</c> (<c>2^7</c>).
/// </summary>
public readonly struct _128 : K_Ulong<_128>
{ public static ulong Value => 128; }

/// <summary>
/// The <see cref="_200"/> readonly struct provides a const type argument equal to
/// <c>200</c>.
/// </summary>
public readonly struct _200 : K_Ulong<_200>
{ public static ulong Value => 200; }

/// <summary>
/// The <see cref="_255"/> readonly struct provides a const type argument equal to
/// <c>255</c>.
/// </summary>
public readonly struct _255 : K_Ulong<_255>
{ public static ulong Value => 255; }

/// <summary>
/// The <see cref="_256"/> readonly struct provides a const type argument equal to
/// <c>256</c> (<c>2^8</c>).
/// </summary>
public readonly struct _256 : K_Ulong<_256>
{ public static ulong Value => 256; }

/// <summary>
/// The <see cref="_511"/> readonly struct provides a const type argument equal to
/// <c>_511</c>.
/// </summary>
public readonly struct _511 : K_Ulong<_511>
{ public static ulong Value => 511; }

/// <summary>
/// The <see cref="_512"/> readonly struct provides a const type argument equal to
/// <c>512</c> (<c>2^9</c>).
/// </summary>
public readonly struct _512 : K_Ulong<_512>
{ public static ulong Value => 512; }

/// <summary>
/// The <see cref="_1023"/> readonly struct provides a const type argument equal to
/// <c>1023</c>.
/// </summary>
public readonly struct _1023 : K_Ulong<_1023>
{ public static ulong Value => 1023; }

/// <summary>
/// The <see cref="_1024"/> readonly struct provides a const type argument equal to
/// <c>1024</c> (<c>2^10</c>).
/// </summary>
public readonly struct _1024 : K_Ulong<_1024>
{ public static ulong Value => 1024; }

/// <summary>
/// The <see cref="_2047"/> readonly struct provides a const type argument equal to
/// <c>2047</c>.
/// </summary>
public readonly struct _2047 : K_Ulong<_2047>
{ public static ulong Value => 2047; }

/// <summary>
/// The <see cref="_2048"/> readonly struct provides a const type argument equal to
/// <c>2048</c> (<c>2^11</c>).
/// </summary>
public readonly struct _2048 : K_Ulong<_2048>
{ public static ulong Value => 2048; }

/// <summary>
/// The <see cref="_4095"/> readonly struct provides a const type argument equal to
/// <c>4095</c>.
/// </summary>
public readonly struct _4095 : K_Ulong<_4095>
{ public static ulong Value => 4095; }

/// <summary>
/// The <see cref="_4096"/> readonly struct provides a const type argument equal to
/// <c>4096</c> (<c>2^12</c>).
/// </summary>
public readonly struct _4096 : K_Ulong<_4096>
{ public static ulong Value => 4096; }

/// <summary>
/// The <see cref="_8191"/> readonly struct provides a const type argument equal to
/// <c>8191</c>.
/// </summary>
public readonly struct _8191 : K_Ulong<_8191>
{ public static ulong Value => 8191; }

/// <summary>
/// The <see cref="_8192"/> readonly struct provides a const type argument equal to
/// <c>8192</c> (<c>2^13</c>).
/// </summary>
public readonly struct _8192 : K_Ulong<_8192>
{ public static ulong Value => 8192; }

/// <summary>
/// The <see cref="_16384"/> readonly struct provides a const type argument equal to
/// <c>16384</c> (<c>2^14</c>).
/// </summary>
public readonly struct _16384 : K_Ulong<_16384>
{ public static ulong Value => 16_384; }

/// <summary>
/// The <see cref="_32768"/> readonly struct provides a const type argument equal to
/// <c>32768</c> (<c>2^15</c>).
/// </summary>
public readonly struct _32768 : K_Ulong<_32768>
{ public static ulong Value => 32_768; }

/// <summary>
/// The <see cref="_65536"/> readonly struct provides a const type argument equal to
/// <c>65536</c> (<c>2^16</c>).
/// </summary>
public readonly struct _65536 : K_Ulong<_65536>
{ public static ulong Value => 65_536; }
