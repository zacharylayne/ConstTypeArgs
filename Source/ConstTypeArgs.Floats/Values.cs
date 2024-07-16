namespace ConstTypeArgs.Floats;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
/// The <see cref="Default"/> struct provides a const type argument equal to the
/// <see langword="default"/> of <see langword="float"/>.
/// </summary>
public readonly struct Default : K_Float<Default>
{ public static float Value => default; }

/// <summary>
/// The <see cref="MinValue"/> struct provides a const type argument equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.single.minvalue">
/// Single.MinValue</see> (<c>-3.40282347E+38</c>).
/// </summary>
public readonly struct MinValue : K_Float<MinValue>
{ public static float Value => float.MinValue; }

/// <summary>
/// The <see cref="MaxValue"/> struct provides a const type argument equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.single.maxvalue">
/// Single.MaxValue</see> (<c>3.40282347E+38</c>).
/// </summary>
public readonly struct MaxValue : K_Float<MaxValue>
{ public static float Value => float.MaxValue; }

/// <summary>
/// The <see cref="E"/> struct provides a const type argument equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.single.e">
/// Single.E</see> (<c>ℯ</c>: <c>2.71828175</c>).
/// </summary>
public readonly struct E : K_Float<E>
{ public static float Value => float.E; }

/// <summary>
/// The <see cref="E"/> struct provides a const type argument equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.single.epsilon">
/// Single.Epsilon</see> (<c>ℯ</c>: <c>1.401298E-45</c>).
/// </summary>
public readonly struct Epsilon : K_Float<Epsilon>
{ public static float Value => float.Epsilon; }

/// <summary>
/// The <see cref="Pi"/> struct provides a const type argument equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.single.pi">
/// Single.Pi</see> (<c>π</c>: <c>3.14159274</c>).
/// </summary>
public readonly struct Pi : K_Float<Pi>
{ public static float Value => float.Pi; }

/// <summary>
/// The <see cref="Phi"/> struct provides a const type argument equal to
/// <c>φ</c> (<c>1.61803398</c>).
/// </summary>
public readonly struct Phi : K_Float<Phi>
{ public static float Value => 1.61803398f; }

/// <summary>
/// The <see cref="Tau"/> struct provides a const type argument equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.single.tau">
/// Single.Tau</see> (<c>6.28318548</c>).
/// </summary>
public readonly struct Tau : K_Float<Tau>
{ public static float Value => float.Tau; }

/// <summary>
/// The <see cref="NaN"/> readonly struct provides a const type argument equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.single.nan">
/// Single.NaN</see>.
/// </summary>
public readonly struct NaN : K_Float<NaN>
{ public static float Value => float.NaN; }

/// <summary>
/// The <see cref="PositiveInfinity"/> readonly struct provides a const type argument equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.single.positiveinfinity">
/// Single.PositiveInfinity</see>.
/// </summary>
public readonly struct PositiveInfinity : K_Float<PositiveInfinity>
{ public static float Value => float.PositiveInfinity; }

/// <summary>
/// The <see cref="NegativeInfinity"/> readonly struct provides a const type argument equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.single.negativeinfinity">
/// Single.NegativeInfinity</see>.
/// </summary>
public readonly struct NegativeInfinity : K_Float<NegativeInfinity>
{ public static float Value => float.NegativeInfinity; }

/// <summary>
/// The <see cref="_0"/> readonly struct provides a const type argument equal to
/// <c>0.0f</c>.
/// </summary>
public readonly struct _0 : K_Float<_0>
{ public static float Value => 0.0f; }