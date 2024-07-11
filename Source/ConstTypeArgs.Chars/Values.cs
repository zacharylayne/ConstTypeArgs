namespace ConstTypeArgs.Chars;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
/// The <see cref="Default"/> readonly struct provides a const type argument equal to the
/// <see langword="default"/> of <see langword="char"/> (<c>/0</c>).
/// </summary>
public readonly struct Default : K_Char<Default>
{ public static char Value => default; }

/// <summary>
/// The <see cref="MinValue"/> readonly struct provides a const type argument equal to
/// <see href="https://learn.microsoft.com/dotnet/api/system.char.minvalue">
/// char.MinValue</see> (<c>/0</c>).
/// </summary>
public readonly struct MinValue : K_Char<MinValue>
{ public static char Value => char.MinValue; }

/// <summary>
/// The <see cref="MaxValue"/> readonly struct provides a const type argument equal to
/// <see href="https://learn.microsoft.com/dotnet/api/system.char.maxvalue">
/// char.MaxValue</see> (<c>\uffff</c>).
/// </summary>
public readonly struct MaxValue : K_Char<MaxValue>
{ public static char Value => char.MaxValue; }
