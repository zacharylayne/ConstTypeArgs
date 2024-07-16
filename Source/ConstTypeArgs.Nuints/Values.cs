namespace ConstTypeArgs.Nuints;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
/// The <see cref="Default"/> readonly struct provides a const type argument equal to the
/// <see langword="default"/> of <see langword="nuint"/> (<c>0</c>).
/// </summary>
public readonly struct Default : K_Nuint<Default>
{ public static nuint Value => default; }

/// <summary>
/// The <see cref="MinValue"/> readonly struct provides a const type argument
/// equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.uintptr.minvalue">
/// UIntPtr.MinValue</see> (<c>0</c>).
/// </summary>
public readonly struct MinValue : K_Nuint<MinValue>
{ public static nuint Value => nuint.MinValue; }

/// <summary>
/// The <see cref="MaxValue"/> readonly struct provides a const type argument
/// equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.uintptr.maxvalue">
/// UIntPtr.MaxValue</see> (<c>18446744073709551615</c>).
/// </summary>
public readonly struct MaxValue : K_Nuint<MaxValue>
{ public static nuint Value => nuint.MaxValue; }

/// <summary>
/// The <see cref="_0"/> readonly struct provides a const type argument equal to
/// <see href="https://docs.microsoft.com/dotnet/api/system.uintptr.zero">
/// UIntPtr.Zero</see> (<c>0</c>).
/// </summary>
public readonly struct _0 : K_Nuint<_0>
{ public static nuint Value => UIntPtr.Zero; }