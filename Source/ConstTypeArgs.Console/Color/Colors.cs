// Ignore Spelling: Spacebar App Sel
#pragma warning disable CS1591  // Missing XML comment for publicly visible type or member

namespace ConstTypeArgs.Console.Color;

/// <summary>
/// The <see cref="Colors"/> static class encapsulates const type arguments for
/// <see href="https://learn.microsoft.com/dotnet/api/system.consolecolor">System.ConsoleColor</see> values.
/// </summary>
/// <seealso cref="ConsoleColor{K}"/>
/// <seealso cref="ConsoleColorArray{K}"/>
public static class Colors
{
    /// <summary>
    /// The <see cref="Black"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolecolor">
    /// System.ConsoleColor.Black</see>.
    /// </summary>
    public readonly struct Black : K_ConsoleColor<Black>
    { public static ConsoleColor Value => ConsoleColor.Black; }

    /// <summary>
    /// The <see cref="Blue"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolecolor">
    /// System.ConsoleColor.Blue</see>.
    /// </summary>
    public readonly struct Blue : K_ConsoleColor<Blue>
    { public static ConsoleColor Value => ConsoleColor.Blue; }

    /// <summary>
    /// The <see cref="Cyan"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolecolor">
    /// System.ConsoleColor.Cyan</see>.
    /// </summary>
    public readonly struct Cyan : K_ConsoleColor<Cyan>
    { public static ConsoleColor Value => ConsoleColor.Cyan; }

    /// <summary>
    /// The <see cref="DarkBlue"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolecolor">
    /// System.ConsoleColor.DarkBlue</see>.
    /// </summary>
    public readonly struct DarkBlue : K_ConsoleColor<DarkBlue>
    { public static ConsoleColor Value => ConsoleColor.DarkBlue; }

    /// <summary>
    /// The <see cref="DarkCyan"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolecolor">
    /// System.ConsoleColor.DarkCyan</see>.
    /// </summary>
    public readonly struct DarkCyan : K_ConsoleColor<DarkCyan>
    { public static ConsoleColor Value => ConsoleColor.DarkCyan; }

    /// <summary>
    /// The <see cref="DarkGray"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolecolor">
    /// System.ConsoleColor.DarkGray</see>.
    /// </summary>
    public readonly struct DarkGray : K_ConsoleColor<DarkGray>
    { public static ConsoleColor Value => ConsoleColor.DarkGray; }

    /// <summary>
    /// The <see cref="DarkGreen"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolecolor">
    /// System.ConsoleColor.DarkGreen</see>.
    /// </summary>
    public readonly struct DarkGreen : K_ConsoleColor<DarkGreen>
    { public static ConsoleColor Value => ConsoleColor.DarkGreen; }

    /// <summary>
    /// The <see cref="DarkMagenta"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolecolor">
    /// System.ConsoleColor.DarkMagenta</see>.
    /// </summary>
    public readonly struct DarkMagenta : K_ConsoleColor<DarkMagenta>
    { public static ConsoleColor Value => ConsoleColor.DarkMagenta; }

    /// <summary>
    /// The <see cref="DarkRed"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolecolor">
    /// System.ConsoleColor.DarkRed</see>.
    /// </summary>
    public readonly struct DarkRed : K_ConsoleColor<DarkRed>
    { public static ConsoleColor Value => ConsoleColor.DarkRed; }

    /// <summary>
    /// The <see cref="DarkYellow"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolecolor">
    /// System.ConsoleColor.DarkYellow</see>.
    /// </summary>
    public readonly struct DarkYellow : K_ConsoleColor<DarkYellow>
    { public static ConsoleColor Value => ConsoleColor.DarkYellow; }

    /// <summary>
    /// The <see cref="Gray"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolecolor">
    /// System.ConsoleColor.Gray</see>.
    /// </summary>
    public readonly struct Gray : K_ConsoleColor<Gray>
    { public static ConsoleColor Value => ConsoleColor.Gray; }

    /// <summary>
    /// The <see cref="Green"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolecolor">
    /// System.ConsoleColor.Green</see>.
    /// </summary>
    public readonly struct Green : K_ConsoleColor<Green>
    { public static ConsoleColor Value => ConsoleColor.Green; }

    /// <summary>
    /// The <see cref="Magenta"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolecolor">
    /// System.ConsoleColor.Magenta</see>.
    /// </summary>
    public readonly struct Magenta : K_ConsoleColor<Magenta>
    { public static ConsoleColor Value => ConsoleColor.Magenta; }

    /// <summary>
    /// The <see cref="Red"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolecolor">
    /// System.ConsoleColor.Red</see>.
    /// </summary>
    public readonly struct Red : K_ConsoleColor<Red>
    { public static ConsoleColor Value => ConsoleColor.Red; }

    /// <summary>
    /// The <see cref="White"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolecolor">
    /// System.ConsoleColor.White</see>.
    /// </summary>
    public readonly struct White : K_ConsoleColor<White>
    { public static ConsoleColor Value => ConsoleColor.White; }

    /// <summary>
    /// The <see cref="Yellow"/> readonly struct provides a const type argument equal to the enumeration value
    /// <see href="https://learn.microsoft.com/dotnet/api/system.consolecolor">
    /// System.ConsoleColor.Yellow</see>.
    /// </summary>
    public readonly struct Yellow : K_ConsoleColor<Yellow>
    { public static ConsoleColor Value => ConsoleColor.Yellow; }
}
