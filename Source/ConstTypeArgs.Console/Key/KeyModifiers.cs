namespace ConstTypeArgs.Console.Key;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
/// The <see cref="KeyModifiers"/> static class encapsulates const type arguments for
/// <see href="https://learn.microsoft.com/dotnet/api/system.consolemodifiers">
/// System.ConsoleModifiers</see> fields.
/// </summary>
/// <seealso cref="KeyModifier{K}"/>
/// <seealso cref="K_KeyModifier"/>
/// <seealso cref="Keys"/>
/// <seealso cref="SpecialKeys"/>
public static class KeyModifiers
{
    /// <summary>
    /// The <see cref="Alt"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolemodifiers">
    /// System.ConsoleModifiers.Alt</see>.
    /// </summary>
    public readonly struct Alt : K_KeyModifier<Alt>
    { public static ConsoleModifiers Value => ConsoleModifiers.Alt; }

    /// <summary>
    /// The <see cref="Control"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolemodifiers">
    /// System.ConsoleModifiers.Control</see>.
    /// </summary>
    public readonly struct Control : K_KeyModifier<Control>
    { public static ConsoleModifiers Value => ConsoleModifiers.Control; }

    /// <summary>
    /// The <see cref="NoKeyModifier"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolemodifiers">
    /// System.ConsoleModifiers.None</see>.
    /// </summary>
    public readonly struct NoKeyModifier : K_KeyModifier<NoKeyModifier>
    { public static ConsoleModifiers Value => ConsoleModifiers.None; }

    /// <summary>
    /// The <see cref="Shift"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolemodifiers">
    /// System.ConsoleModifiers.Shift</see>.
    /// </summary>
    public readonly struct Shift : K_KeyModifier<Shift>
    { public static ConsoleModifiers Value => ConsoleModifiers.Shift; }
}
