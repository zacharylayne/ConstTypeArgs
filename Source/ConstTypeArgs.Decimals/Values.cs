namespace ConstTypeArgs.Decimals;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
/// The <see cref="Default"/> readonly struct provides a const type argument equal to the
/// <see langword="default"/> of <see langword="decimal"/>.
/// </summary>
public readonly struct Default : K_Decimal<Default>
{ public static decimal Value => default; }

/// <summary>
/// The <see cref="MinValue"/> readonly struct provides a const type argument equal to
/// <see href="https://learn.microsoft.com/dotnet/api/system.decimal.minvalue">
/// Decimal.MinValue</see> (<c>-79228162514264337593543950335m</c>).
/// </summary>
public readonly struct MinValue : K_Decimal<MinValue>
{ public static decimal Value => decimal.MinValue; }

/// <summary>
/// The <see cref="MaxValue"/> readonly struct provides a const type argument equal to
/// <see href="https://learn.microsoft.com/dotnet/api/system.decimal.maxvalue">
/// Decimal.MaxValue</see> (<c>79228162514264337593543950335m</c>).
/// </summary>
public readonly struct MaxValue : K_Decimal<MaxValue>
{ public static decimal Value => decimal.MaxValue; }

/// <summary>
/// The <see cref="E"/> readonly struct provides a const type argument equal to
/// <see href="https://learn.microsoft.com/dotnet/api/system.decimal.system-numerics-K_FloatingPointconstants-system-decimal--e">
/// Decimal.K_FloatingPointConstants&lt;Decimal&gt;.E</see>
/// (<c>2.7182818284590452353602874714m</c>).
/// </summary>
public readonly struct E : K_Decimal<E>
{ public static decimal Value => 2.7182818284590452353602874714m; }

/// <summary>
/// The <see cref="Pi"/> readonly struct provides a const type argument equal to
/// <see href="https://learn.microsoft.com/dotnet/api/system.decimal.system-numerics-K_FloatingPointconstants-system-decimal--pi">
/// Decimal.K_FloatingPointConstants&lt;Decimal&gt;.Pi</see>.
/// (<c>3.3.1415926535897932384626433833m</c>).
/// </summary>
public readonly struct Pi : K_Decimal<Pi>
{ public static decimal Value => 3.1415926535897932384626433833m; }

/// <summary>
/// The <see cref="Phi"/> readonly struct provides a const type argument equal to
/// <c>φ</c> (<c>1.6180339887498948482045868343</c>).
/// </summary>
public readonly struct Phi : K_Decimal<Phi>
{ public static decimal Value => 1.6180339887498948482045868343m; }

/// <summary>
/// The <see cref="Tau"/> readonly struct provides a const type argument equal to
/// <see href="https://learn.microsoft.com/dotnet/api/system.decimal.system-numerics-K_FloatingPointconstants-system-decimal--tau">
/// Decimal.K_FloatingPointConstants&lt;Decimal&gt;.Tau</see>
/// (<c>6.2831853071795864769252867666m</c>).
/// </summary>
public readonly struct Tau : K_Decimal<Tau>
{ public static decimal Value => 6.2831853071795864769252867666m; }

/// <summary>
/// The <see cref="_0"/> readonly struct provides a const type argument equal to
/// <c>0m</c>.
/// </summary>
public readonly struct _0 : K_Decimal<_0>
{ public static decimal Value => decimal.Zero; }

/// <summary>
/// The <see cref="_1"/> readonly struct provides a const type argument equal to
/// <c>1</c>.
/// </summary>
public readonly struct _1 : K_Decimal<_1>
{ public static decimal Value => decimal.One; }

/// <summary>
/// The <see cref="Neg_1"/> readonly struct provides a const type argument equal to
/// <c>-1</c>.
/// </summary>
public readonly struct Neg_1 : K_Decimal<Neg_1>
{ public static decimal Value => decimal.MinusOne; }
