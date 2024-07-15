namespace ConstTypeArgs.Strings;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// See comments in .NET source code for why this is not a compile-time constant.
/// <summary>
/// The <see cref="Empty"/> readonly struct provides a const type argument
/// equal to <see cref="string.Empty"/>.
/// </summary>
public readonly struct Empty : K_String<Empty>
{ public static string Value => string.Empty; }

// It might be good to avoid using Boolean.FalseString, since it is not a compile-time constant.
/// <summary>
/// The <see cref="False"/> readonly struct provides a const type argument
/// equal to <c>False</c>.
/// </summary>
public readonly struct False : K_String<False>
{ public static string Value => "False"; }

// It might be good to avoid using Boolean.TrueString, since it is not a compile-time constant.
/// <summary>
/// The <see cref="True"/> readonly struct provides a const type argument
/// equal to <c>True</c>.
/// </summary>
public readonly struct True : K_String<True>
{ public static string Value => "True"; }

/// <summary>
/// The <see cref="NewLine"/> readonly struct provides a const type argument
/// equal to
/// <see href="https://learn.microsoft.com/dotnet/api/system.environment.newline">
/// Environment.NewLine</see>.
/// </summary>
public readonly struct NewLine : K_String<NewLine>
{ public static string Value => Environment.NewLine; }

/// <summary>
/// The <see cref="WindowsNewLine"/> readonly struct provides a const type argument
/// equal to <c>\r\n</c>.
/// </summary>
public readonly struct WindowsNewLine : K_String<WindowsNewLine>
{ public static string Value => "\r\n"; }

/// <summary>
/// The <see cref="UnixNewLine"/> readonly struct provides a const type argument
/// equal to <c>\n</c>.
/// </summary>
public readonly struct UnixNewLine : K_String<UnixNewLine>
{ public static string Value => "\n"; }