namespace ConstTypeArgs.Nints;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
/// The <see cref="Default"/> readonly struct provides a const type argument equal to the
/// <see langword="default"/> of <see langword="nint"/> (<c>0</c>).
/// </summary>
public readonly struct Default : K_Nint<Default>
{ public static nint Value => default; }

/// <summary>
/// The <see cref="MinValue"/> readonly struct provides a const type argument
/// equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.intptr.minvalue">
/// IntPtr.MinValue</see> (<c>-9223372036854775808</c>).
/// </summary>
public readonly struct MinValue : K_Nint<MinValue>
{ public static nint Value => nint.MinValue; }

/// <summary>
/// The <see cref="MaxValue"/> readonly struct provides a const type argument
/// equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.intptr.maxvalue">
/// IntPtr.MaxValue</see> (<c>9223372036854775807</c>).
/// </summary>
public readonly struct MaxValue : K_Nint<MaxValue>
{ public static nint Value => nint.MaxValue; }

/// <summary>
/// The <see cref="_0"/> readonly struct provides a const type argument equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.intptr.zero">
/// IntPtr.Zero</see> (<c>0</c>).
/// </summary>
public readonly struct _0 : K_Nint<_0>
{ public static nint Value => nint.Zero; }