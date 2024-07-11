#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace ConstTypeArgs.Bools;

/// <summary>
/// The <see cref="Default"/> readonly struct provides a const type argument equal to the
/// <see langword="default"/> of <see langword="bool"/> (<c>false</c>).
/// </summary>
public readonly struct Default : K_Bool<Default>
{ public static bool Value => default; }

/// <summary>
/// The <see cref="True"/> readonly struct provides a const type argument equal to
/// <see langword="true"/>.
/// </summary>
/// <seealso cref="False"/>
public readonly struct True : K_Bool<True>
{ public static bool Value => true; }

/// <summary>
/// The <see cref="False"/> readonly struct provides a const type argument equal to
/// <see langword="false"/>.
/// </summary>
/// <seealso cref="True"/>
public readonly struct False : K_Bool<False>
{ public static bool Value => false; }
