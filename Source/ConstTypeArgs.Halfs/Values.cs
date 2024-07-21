namespace ConstTypeArgs.Halfs;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
/// The <see cref="Default"/> struct provides a const type argument equal to the
/// <see langword="default"/> of
/// <see href="https://learn.microsoft.com/dotnet/api/system.half">
/// Half</see> (<c>0</c>).
/// </summary>
public readonly struct Default : K_Half<Default>
{ public static Half Value => default; }

/// <summary>
/// The <see cref="MinValue"/> struct provides a const type argument equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.half.minvalue">
/// Half.MinValue</see> (<c>-65504</c>).
/// </summary>
public readonly struct MinValue : K_Half<MinValue>
{ public static Half Value => Half.MinValue; }

/// <summary>
/// The <see cref="MaxValue"/> struct provides a const type argument equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.half.maxvalue">
/// Half.MaxValue</see> (<c>65504</c>).
/// </summary>
public readonly struct MaxValue : K_Half<MaxValue>
{ public static Half Value => Half.MaxValue; }

/// <summary>
/// The <see cref="NaN"/> readonly struct provides a const type argument equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.half.nan">
/// Half.NaN</see>.
/// </summary>
public readonly struct NaN : K_Half<NaN>
{ public static Half Value => Half.NaN; }

/// <summary>
/// The <see cref="PositiveInfinity"/> readonly struct provides a const type argument equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.half.positiveinfinity">
/// Half.PositiveInfinity</see>.
/// </summary>
public readonly struct PositiveInfinity : K_Half<PositiveInfinity>
{ public static Half Value => Half.PositiveInfinity; }

/// <summary>
/// The <see cref="NegativeInfinity"/> readonly struct provides a const type argument equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.half.negativeinfinity">
/// Half.NegativeInfinity</see>.
/// </summary>
public readonly struct NegativeInfinity : K_Half<NegativeInfinity>
{ public static Half Value => Half.NegativeInfinity; }

/// <summary>
/// The <see cref="_0"/> readonly struct provides a const type argument equal to
/// <c>0</c>.
/// </summary>
public readonly struct _0 : K_Half<_0>
{ public static Half Value => Half.Zero; }

/// <summary>
/// The <see cref="_1"/> readonly struct provides a const type argument equal to
/// <c>1</c>.
/// </summary>
public readonly struct _1 : K_Half<_1>
{ public static Half Value => Half.One; }

/// <summary>
/// The <see cref="Neg_1"/> readonly struct provides a const type argument equal to
/// <c>-1</c>.
/// </summary>
public readonly struct Neg_1 : K_Half<Neg_1>
{ public static Half Value => Half.NegativeOne; }
