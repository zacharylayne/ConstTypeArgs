namespace ConstTypeArgs.Doubles;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
/// The <see cref="Default"/> readonly struct provides a const type argument equal to the
/// <see langword="default"/> of <see langword="double"/> (<c>0</c>).
/// </summary>
public readonly struct Default : K_Double<Default>
{ public static double Value => default; }

/// <summary>
/// The <see cref="MinValue"/> readonly struct provides a const type argument equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.double.minvalue">
/// Double.MinValue</see> (<c>-1.7976931348623157E+308</c>).
/// </summary>
public readonly struct MinValue : K_Double<MinValue>
{ public static double Value => double.MinValue; }

/// <summary>
/// The <see cref="MaxValue"/> readonly struct provides a const type argument equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.double.maxvalue">
/// Double.MaxValue</see> (<c>1.7976931348623157E+308</c>).
/// </summary>
public readonly struct MaxValue : K_Double<MaxValue>
{ public static double Value => double.MaxValue; }

/// <summary>
/// The <see cref="E"/> readonly struct provides a const type argument equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.double.e">
/// Double.E</see> (<c>2.7182818284590452354</c>).
/// </summary>
public readonly struct E : K_Double<E>
{ public static double Value => double.E; }

/// <summary>
/// The <see cref="Tau"/> readonly struct provides a const type argument equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.double.epsilon">
/// Double.Epsilon</see> (<c>4.94065645841247E-324</c>).
/// </summary>
public readonly struct Epsilon : K_Double<Epsilon>
{ public static double Value => double.Epsilon; }

/// <summary>
/// The <see cref="Pi"/> readonly struct provides a const type argument equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.double.pi">
/// Double.Pi</see> (<c>3.14159265358979323846</c>).
/// </summary>
public readonly struct Pi : K_Double<Pi>
{ public static double Value => double.Pi; }

/// <summary>
/// The <see cref="Phi"/> readonly struct provides a const type argument equal to
/// <c>φ</c> (<c>1.6180339887498948</c>).
/// </summary>
public readonly struct Phi : K_Double<Phi>
{ public static double Value => 1.6180339887498948; }

/// <summary>
/// The <see cref="Tau"/> readonly struct provides a const type argument equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.double.tau">
/// Double.Tau</see> (<c>6.283185307179586476925</c>).
/// </summary>
public readonly struct Tau : K_Double<Tau>
{ public static double Value => double.Tau; }

/// <summary>
/// The <see cref="NaN"/> readonly struct provides a const type argument equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.double.nan">
/// Double.NaN</see>.
/// </summary>
public readonly struct NaN : K_Double<NaN>
{ public static double Value => double.NaN; }

/// <summary>
/// The <see cref="PositiveInfinity"/> readonly struct provides a const type argument equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.double.positiveinfinity">
/// Double.PositiveInfinity</see>.
/// </summary>
public readonly struct PositiveInfinity : K_Double<PositiveInfinity>
{ public static double Value => double.PositiveInfinity; }

/// <summary>
/// The <see cref="NegativeInfinity"/> readonly struct provides a const type argument equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.double.negativeinfinity">
/// Double.NegativeInfinity</see>.
/// </summary>
public readonly struct NegativeInfinity : K_Double<NegativeInfinity>
{ public static double Value => double.NegativeInfinity; }

/// <summary>
/// The <see cref="_0"/> readonly struct provides a const type argument equal to
/// <c>0.0</c>.
/// </summary>
public readonly struct _0 : K_Double<_0>
{ public static double Value => 0.0; }
