namespace ConstTypeArgs.Uints;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
/// The <see cref="Default"/> readonly struct provides a const type argument equal to the
/// <see langword="default"/> of <see langword="uint"/> (<c>0</c>).
/// </summary>
public readonly struct Default : K_Uint<Default>
{ public static uint Value => default; }

/// <summary>
/// The <see cref="MinValue"/> readonly struct provides a const type argument
/// equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.uint32.minvalue">
/// UInt32.MinValue</see> (<c>0</c>).
/// </summary>
public readonly struct MinValue : K_Uint<MinValue>
{ public static uint Value => uint.MinValue; }

/// <summary>
/// The <see cref="MaxValue"/> readonly struct provides a const type argument
/// equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.uint32.maxvalue">
/// UInt32.MaxValue</see> (<c>4294967295</c>).
/// </summary>
public readonly struct MaxValue : K_Uint<MaxValue>
{ public static uint Value => uint.MaxValue; }

/// <summary>
/// The <see cref="MaxDigits"/> readonly struct provides a const type argument equal to
/// the maximum number of digits in a <see langword="uint"/> (<c>10</c>).
/// </summary>
public readonly struct MaxDigits : K_Uint<MaxDigits>
{ public static uint Value => 10; } // 4_294_967_295

/// <summary>
/// The <see cref="MaxHexDigits"/> readonly struct provides a const type argument equal to
/// the maximum number of hex digits in a <see langword="uint"/> (<c>8</c>).
/// </summary>
public readonly struct MaxHexDigits : K_Uint<MaxHexDigits>
{ public static uint Value => 8; } // 0xFFFF_FFFF

/// <summary>
/// The <see cref="_0"/> readonly struct provides a const type argument equal to
/// <c>0</c>.
/// </summary>
public readonly struct _0 : K_Uint<_0>
{ public static uint Value => 0; }

/// <summary>
/// The <see cref="_1"/> readonly struct provides a const type argument equal to
/// <c>1</c>.
/// </summary>
public readonly struct _1 : K_Uint<_1>
{ public static uint Value => 1; }

/// <summary>
/// The <see cref="_2"/> readonly struct provides a const type argument equal to
/// <c>2</c>.
/// </summary>
public readonly struct _2 : K_Uint<_2>
{ public static uint Value => 2; }

/// <summary>
/// The <see cref="_3"/> readonly struct provides a const type argument equal to
/// <c>3</c>.
/// </summary>
public readonly struct _3 : K_Uint<_3>
{ public static uint Value => 3; }

/// <summary>
/// The <see cref="_4"/> readonly struct provides a const type argument equal to
/// <c>4</c>.
/// </summary>
public readonly struct _4 : K_Uint<_4>
{ public static uint Value => 4; }

/// <summary>
/// The <see cref="_5"/> readonly struct provides a const type argument equal to
/// <c>5</c>.
/// </summary>
public readonly struct _5 : K_Uint<_5>
{ public static uint Value => 5; }

/// <summary>
/// The <see cref="_6"/> readonly struct provides a const type argument equal to
/// <c>6</c>.
/// </summary>
public readonly struct _6 : K_Uint<_6>
{ public static uint Value => 6; }

/// <summary>
/// The <see cref="_7"/> readonly struct provides a const type argument equal to
/// <c>7</c>.
/// </summary>
public readonly struct _7 : K_Uint<_7>
{ public static uint Value => 7; }

/// <summary>
/// The <see cref="_8"/> readonly struct provides a const type argument equal to
/// <c>8</c>.
/// </summary>
public readonly struct _8 : K_Uint<_8>
{ public static uint Value => 8; }

/// <summary>
/// The <see cref="_9"/> readonly struct provides a const type argument equal to
/// <c>9</c>.
/// </summary>
public readonly struct _9 : K_Uint<_9>
{ public static uint Value => 9; }

/// <summary>
/// The <see cref="_10"/> readonly struct provides a const type argument equal to
/// <c>10</c>.
/// </summary>
public readonly struct _10 : K_Uint<_10>
{ public static uint Value => 10; }

/// <summary>
/// The <see cref="_11"/> readonly struct provides a const type argument equal to
/// <c>11</c>.
/// </summary>
public readonly struct _11 : K_Uint<_11>
{ public static uint Value => 11; }

/// <summary>
/// The <see cref="_12"/> readonly struct provides a const type argument equal to
/// <c>12</c>.
/// </summary>
public readonly struct _12 : K_Uint<_12>
{ public static uint Value => 12; }

/// <summary>
/// The <see cref="_13"/> readonly struct provides a const type argument equal to
/// <c>13</c>.
/// </summary>
public readonly struct _13 : K_Uint<_13>
{ public static uint Value => 13; }

/// <summary>
/// The <see cref="_14"/> readonly struct provides a const type argument equal to
/// <c>14</c>.
/// </summary>
public readonly struct _14 : K_Uint<_14>
{ public static uint Value => 14; }

/// <summary>
/// The <see cref="_15"/> readonly struct provides a const type argument equal to
/// <c>15</c>.
/// </summary>
public readonly struct _15 : K_Uint<_15>
{ public static uint Value => 15; }

/// <summary>
/// The <see cref="_16"/> readonly struct provides a const type argument equal to
/// <c>16</c> (<c>2^4</c>).
/// </summary>
public readonly struct _16 : K_Uint<_16>
{ public static uint Value => 16; }

/// <summary>
/// The <see cref="_25"/> readonly struct provides a const type argument equal to
/// <c>25</c>.
/// </summary>
public readonly struct _25 : K_Uint<_25>
{ public static uint Value => 25; }

/// <summary>
/// The <see cref="_31"/> readonly struct provides a const type argument equal to
/// <c>31</c>.
/// </summary>
public readonly struct _31 : K_Uint<_31>
{ public static uint Value => 31; }

/// <summary>
/// The <see cref="_32"/> readonly struct provides a const type argument equal to
/// <c>32</c> (<c>2^5</c>).
/// </summary>
public readonly struct _32 : K_Uint<_32>
{ public static uint Value => 32; }

/// <summary>
/// The <see cref="_50"/> readonly struct provides a const type argument equal to
/// <c>50</c>.
/// </summary>
public readonly struct _50 : K_Uint<_50>
{ public static uint Value => 50; }

/// <summary>
/// The <see cref="_63"/> readonly struct provides a const type argument equal to
/// <c>63</c>.
/// </summary>
public readonly struct _63 : K_Uint<_63>
{ public static uint Value => 63; }

/// <summary>
/// The <see cref="_64"/> readonly struct provides a const type argument equal to
/// <c>64</c> (<c>2^6</c>).
/// </summary>
public readonly struct _64 : K_Uint<_64>
{ public static uint Value => 64; }

/// <summary>
/// The <see cref="_100"/> readonly struct provides a const type argument equal to
/// <c>100</c>.
/// </summary>
public readonly struct _100 : K_Uint<_100>
{ public static uint Value => 100; }

/// <summary>
/// The <see cref="_127"/> readonly struct provides a const type argument equal to
/// <c>127</c>.
/// </summary>
public readonly struct _127 : K_Uint<_127>
{ public static uint Value => 127; }

/// <summary>
/// The <see cref="_128"/> readonly struct provides a const type argument equal to
/// <c>128</c> (<c>2^7</c>).
/// </summary>
public readonly struct _128 : K_Uint<_128>
{ public static uint Value => 128; }

/// <summary>
/// The <see cref="_200"/> readonly struct provides a const type argument equal to
/// <c>200</c>.
/// </summary>
public readonly struct _200 : K_Uint<_200>
{ public static uint Value => 200; }

/// <summary>
/// The <see cref="_255"/> readonly struct provides a const type argument equal to
/// <c>255</c>.
/// </summary>
public readonly struct _255 : K_Uint<_255>
{ public static uint Value => 255; }

/// <summary>
/// The <see cref="_256"/> readonly struct provides a const type argument equal to
/// <c>256</c> (<c>2^8</c>).
/// </summary>
public readonly struct _256 : K_Uint<_256>
{ public static uint Value => 256; }

/// <summary>
/// The <see cref="_511"/> readonly struct provides a const type argument equal to
/// <c>_511</c>.
/// </summary>
public readonly struct _511 : K_Uint<_511>
{ public static uint Value => 511; }

/// <summary>
/// The <see cref="_512"/> readonly struct provides a const type argument equal to
/// <c>512</c> (<c>2^9</c>).
/// </summary>
public readonly struct _512 : K_Uint<_512>
{ public static uint Value => 512; }

/// <summary>
/// The <see cref="_1023"/> readonly struct provides a const type argument equal to
/// <c>1023</c>.
/// </summary>
public readonly struct _1023 : K_Uint<_1023>
{ public static uint Value => 1023; }

/// <summary>
/// The <see cref="_1024"/> readonly struct provides a const type argument equal to
/// <c>1024</c> (<c>2^10</c>).
/// </summary>
public readonly struct _1024 : K_Uint<_1024>
{ public static uint Value => 1024; }

/// <summary>
/// The <see cref="_2047"/> readonly struct provides a const type argument equal to
/// <c>2047</c>.
/// </summary>
public readonly struct _2047 : K_Uint<_2047>
{ public static uint Value => 2047; }

/// <summary>
/// The <see cref="_2048"/> readonly struct provides a const type argument equal to
/// <c>2048</c> (<c>2^11</c>).
/// </summary>
public readonly struct _2048 : K_Uint<_2048>
{ public static uint Value => 2048; }

/// <summary>
/// The <see cref="_4095"/> readonly struct provides a const type argument equal to
/// <c>4095</c>.
/// </summary>
public readonly struct _4095 : K_Uint<_4095>
{ public static uint Value => 4095; }

/// <summary>
/// The <see cref="_4096"/> readonly struct provides a const type argument equal to
/// <c>4096</c> (<c>2^12</c>).
/// </summary>
public readonly struct _4096 : K_Uint<_4096>
{ public static uint Value => 4096; }

/// <summary>
/// The <see cref="_8191"/> readonly struct provides a const type argument equal to
/// <c>8191</c>.
/// </summary>
public readonly struct _8191 : K_Uint<_8191>
{ public static uint Value => 8191; }

/// <summary>
/// The <see cref="_8192"/> readonly struct provides a const type argument equal to
/// <c>8192</c> (<c>2^13</c>).
/// </summary>
public readonly struct _8192 : K_Uint<_8192>
{ public static uint Value => 8192; }

/// <summary>
/// The <see cref="_16384"/> readonly struct provides a const type argument equal to
/// <c>16384</c> (<c>2^14</c>).
/// </summary>
public readonly struct _16384 : K_Uint<_16384>
{ public static uint Value => 16_384; }

/// <summary>
/// The <see cref="_32768"/> readonly struct provides a const type argument equal to
/// <c>32768</c> (<c>2^15</c>).
/// </summary>
public readonly struct _32768 : K_Uint<_32768>
{ public static uint Value => 32_768; }

/// <summary>
/// The <see cref="_65536"/> readonly struct provides a const type argument equal to
/// <c>65536</c> (<c>2^16</c>).
/// </summary>
public readonly struct _65536 : K_Uint<_65536>
{ public static uint Value => 65_536; }
